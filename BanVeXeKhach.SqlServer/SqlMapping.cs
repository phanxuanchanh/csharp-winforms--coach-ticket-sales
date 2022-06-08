using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BanVeXeKhach.SqlServer
{
    public class SqlMapping
    {
        private Reflection reflection;
        private DataTable dataTable;
        private SqlDataReader sqlDataReader;

        public DataTable DataTable { get => dataTable; set => dataTable = value; }
        public SqlDataReader SqlDataReader { get => sqlDataReader; set => sqlDataReader = value; }

        public SqlMapping()
        {
            reflection = new Reflection();
        }

        public Dictionary<string, object> ToDictionary()
        {
            if (dataTable == null && sqlDataReader == null)
                throw new Exception("@'dataTable' or 'sqlDataReader' must not be null");

            if (dataTable != null)
                return ToDictionary(dataTable);

            return ToDictionary(sqlDataReader);
        }

        public List<Dictionary<string, object>> ToDictionaryList()
        {
            if (dataTable == null && sqlDataReader == null)
                throw new Exception("@'dataTable' or 'sqlDataReader' must not be null");

            if (dataTable != null)
                return ToDictionaryList(dataTable);

            return ToDictionaryList(sqlDataReader);
        }

        private Dictionary<string, object> ToDictionary(DataTable dataTable)
        {
            Dictionary<string, object> dict = null;
            DataRow row = dataTable.AsEnumerable().FirstOrDefault();
            if (row == null)
                return null;
            dict = new Dictionary<string, object>();
            foreach (DataColumn column in row.Table.Columns)
            {
                object value = row[column.Caption];
                dict.Add(column.Caption, (value is System.DBNull) ? null : value);
            }
            return dict;
        }

        private List<Dictionary<string, object>> ToDictionaryList(DataTable dataTable)
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            foreach (DataRow row in dataTable.AsEnumerable())
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                foreach (DataColumn column in row.Table.Columns)
                {
                    object value = row[column.Caption];
                    dict.Add(column.Caption, (value is System.DBNull) ? null : value);
                }
                list.Add(dict);
            }
            return list;
        }

        public Dictionary<string, object> ToDictionary(SqlDataReader reader)
        {
            Dictionary<string, object> dict = null;
            if (reader.Read())
            {
                dict = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    object value = reader.GetValue(i);
                    dict.Add(reader.GetName(i), (value is System.DBNull) ? null : value);
                }
            }
            reader.Close();
            return dict;
        }

        public List<Dictionary<string, object>> ToDictionaryList(SqlDataReader reader)
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    object value = reader.GetValue(i);
                    dict.Add(reader.GetName(i), (value is System.DBNull) ? null : value);
                }
                list.Add(dict);
            }
            return list;
        }

        private List<string> GetPrefixKeys(Dictionary<string, object> pairs)
        {
            List<string> keys = new List<string>();
            foreach (string rawKey in pairs.Keys.ToList())
            {
                string key = GetPrefixKey(rawKey);
                if (!keys.Any(k => k == key))
                    keys.Add(key);
            }
            return keys;
        }

        private string GetPrefixKey(string input)
        {
            return input.Substring(0, input.IndexOf('.'));
        }

        private string GetSuffixKey(string input)
        {
            return input.Substring(input.IndexOf('.') + 1);
        }

        public T To<T>()
        {
            if (dataTable == null && sqlDataReader == null)
                throw new Exception("@'dataTable' or 'sqlDataReader' must not be null");

            if (dataTable != null)
                return To<T>(dataTable);

            return To<T>(sqlDataReader);
        }

        public List<T> ToList<T>()
        {
            if (dataTable == null && sqlDataReader == null)
                throw new Exception("@'dataTable' or 'sqlDataReader' must not be null");

            if (dataTable != null)
                return ToList<T>(dataTable);

            return ToList<T>(sqlDataReader);
        }

        private T To<T>(Dictionary<string, object> pairs)
        {
            if (pairs == null)
                return default(T);
            object model = reflection.CreateInstance<T>();
            model = (T)reflection.SetValuesForFieldsOfObject(model, pairs);
            if (model == null)
                return default(T);

            string pattern = "(^.)[a-zA-Z0-9]{1,}[.]{1}[a-zA-Z0-9]{1,}$";
            int count = 0;
            while (count < 1)
            {
                Dictionary<string, object> subProperties = pairs.Where(p => Regex.IsMatch(p.Key, pattern))
                    .ToDictionary(p => p.Key, p => p.Value);
                List<string> prefixKeys = GetPrefixKeys(subProperties);

                foreach (string prefixKey in prefixKeys)
                {
                    //PropertyInfo subPropertyInfo = reflection.GetProperty(model, prefixKey);
                    FieldInfo subFieldInfo = reflection.GetField(model, prefixKey);
                    if (subFieldInfo != null)
                    {
                        object subModel = Activator.CreateInstance(subFieldInfo.FieldType);
                        Dictionary<string, object> propertiesOfSubModel = subProperties
                            .Where(p => p.Key.SubStr(0, p.Key.IndexOf('.')) == prefixKey)
                            .ToDictionary(p => GetSuffixKey(p.Key), p => p.Value);
                        subModel = reflection.SetValuesForPropertiesOfObject(subModel, propertiesOfSubModel);
                        if (subModel != null)
                            subFieldInfo.SetValue(model, subModel);
                    }
                }
                count++;
            }

            return (T)model;
        }

        private T To<T>(DataTable dataTable)
        {
            return To<T>(ToDictionary(dataTable));
        }

        private List<T> ToList<T>(DataTable dataTable)
        {
            List<T> list = new List<T>();
            foreach (Dictionary<string, object> pairs in ToDictionaryList(dataTable))
            {
                list.Add(To<T>(pairs));
            }
            return list;
        }

        private T To<T>(SqlDataReader sqlDataReader)
        {
            return To<T>(ToDictionary(sqlDataReader));
        }

        private List<T> ToList<T>(SqlDataReader sqlDataReader)
        {
            List<T> list = new List<T>();
            foreach (Dictionary<string, object> pairs in ToDictionaryList(sqlDataReader))
            {
                list.Add(To<T>(pairs));
            }
            return list;
        }
    }
}
