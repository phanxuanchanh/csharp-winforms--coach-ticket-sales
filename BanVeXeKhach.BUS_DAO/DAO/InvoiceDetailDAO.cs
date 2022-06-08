using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.DAO
{
    public class InvoiceDetailDAO
    {
        private static SqlExecution sqlExecution = DataAccessConfiguration.GetSqlExecution();

        public static List<InvoiceDetail> GetInvoiceDetails(long invoiceId)
        {
            string commandText = @"
                Select InvoiceDetail.*, Invoice.ID as 'invoice.InvoiceId', Invoice.totalMoney as 'invoice.TotalMoney',
                    CoachTrip.ID as 'coachTrip.CoachTripId', CoachTrip.[name] as'coachTrip.Name', 
                    CoachTrip.departureDate as'coachTrip.DepartureDate', CoachTrip.arrivalDate as'coachTrip.ArrivalDate'
                from Invoice, InvoiceDetail, CoachTrip 
                where InvoiceDetail.invoiceId = Invoice.ID
                    and InvoiceDetail.coachTripId = CoachTrip.ID and Invoice.ID = @invoiceId";

            return sqlExecution
                .ToList<InvoiceDetail>(commandText, CommandType.Text, new SqlParameter("@invoiceId", invoiceId));
        }

        public static async Task<List<InvoiceDetail>> GetInvoiceDetailsAsync(long invoiceId)
        {
            string commandText = @"
                Select InvoiceDetail.*, Invoice.ID as 'invoice.InvoiceId', Invoice.totalMoney as 'invoice.TotalMoney',
                    CoachTrip.ID as 'coachTrip.CoachTripId', CoachTrip.[name] as'coachTrip.Name', 
                    CoachTrip.departureDate as'coachTrip.DepartureDate', CoachTrip.arrivalDate as'coachTrip.ArrivalDate'
                from Invoice, InvoiceDetail, CoachTrip 
                where InvoiceDetail.invoiceId = Invoice.ID
                    and InvoiceDetail.coachTripId = CoachTrip.ID and Invoice.ID = @invoiceId";

            return await sqlExecution
                .ToListAsync<InvoiceDetail>(commandText, CommandType.Text, new SqlParameter("@invoiceId", invoiceId));
        }

        public static List<int> GetSelectedSeatByCoachTripId(long coachTripId)
        {
            List<int> selectedSeats = new List<int>();
            string commandText = "Select * from InvoiceDetail where coachTripId = @coachTripId";
            using (SqlDataReader reader = sqlExecution.ExecuteReader(
                commandText, CommandType.Text, new SqlParameter("@coachTripId", coachTripId)))
            {
                while (reader.Read())
                {
                    selectedSeats.Add((int)reader["seatPosition"]);
                }
                return selectedSeats;
            }
        }

        public static async Task<List<int>> GetSelectedSeatByCoachTripIdAsync(long coachTripId)
        {
            List<int> selectedSeats = new List<int>();
            string commandText = "Select * from InvoiceDetail where coachTripId = @coachTripId";
            using (SqlDataReader reader = await sqlExecution.ExecuteReaderAsync(
                commandText, CommandType.Text, new SqlParameter("@coachTripId", coachTripId)))
            {
                while (reader.Read())
                {
                    selectedSeats.Add((int)reader["seatPosition"]);
                }
                return selectedSeats;
            }
        }

        public static bool CreateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            string commandText = @"
                Insert into InvoiceDetail 
                    values (@invoiceId, @coachTripId, @seatPosition, @price, @surcharge, @note, @intoMoney, @status)";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@invoiceId", invoiceDetail.Invoice.InvoiceId),
                new SqlParameter("@coachTripId", invoiceDetail.CoachTrip.CoachTripId),
                new SqlParameter("@seatPosition", invoiceDetail.SeatPosition),
                new SqlParameter("@price", invoiceDetail.Price),
                new SqlParameter("@surcharge", invoiceDetail.Surcharge),
                new SqlParameter("@note", invoiceDetail.Note),
                new SqlParameter("@intoMoney", invoiceDetail.IntoMoney),
                new SqlParameter("@status", invoiceDetail.Status)
            );

            return affected > 0;
        }

        public static async Task<bool> CreateInvoiceDetailAsync(InvoiceDetail invoiceDetail)
        {
            string commandText = @"
                Insert into InvoiceDetail 
                    values (@invoiceId, @coachTripId, @seatPosition, @price, @surcharge, @note, @intoMoney, @status)";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@invoiceId", invoiceDetail.Invoice.InvoiceId),
                new SqlParameter("@coachTripId", invoiceDetail.CoachTrip.CoachTripId),
                new SqlParameter("@seatPosition", invoiceDetail.SeatPosition),
                new SqlParameter("@price", invoiceDetail.Price),
                new SqlParameter("@surcharge", invoiceDetail.Surcharge),
                new SqlParameter("@note", invoiceDetail.Note),
                new SqlParameter("@intoMoney", invoiceDetail.IntoMoney),
                new SqlParameter("@status", invoiceDetail.Status)
            );

            return affected > 0;
        }

        public static bool UpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            string commandText = @"
                Update InvoiceDetail 
                set price = @price, surcharge = @surcharge, note = @note, 
                    intoMoney = @intoMoney, status = @status
                where invoiceId = @invoiceId and coachTripId = @coachTripId and seatPosition = @seatPosition";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@price", invoiceDetail.Price),
                new SqlParameter("@surcharge", invoiceDetail.Surcharge),
                new SqlParameter("@note", invoiceDetail.Note),
                new SqlParameter("@intoMoney", invoiceDetail.IntoMoney),
                new SqlParameter("@status", invoiceDetail.Status),
                new SqlParameter("@invoiceId", invoiceDetail.Invoice.InvoiceId),
                new SqlParameter("@coachTripId", invoiceDetail.CoachTrip.CoachTripId),
                new SqlParameter("@seatPosition", invoiceDetail.SeatPosition)
            );

            return affected > 0;
        }

        public static async Task<bool> UpdateInvoiceDetailAsync(InvoiceDetail invoiceDetail)
        {
            string commandText = @"
                Update InvoiceDetail 
                set price = @price, surcharge = @surcharge, note = @note, 
                    intoMoney = @intoMoney, status = @status
                where invoiceId = @invoiceId and coachTripId = @coachTripId and seatPosition = @seatPosition";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@price", invoiceDetail.Price),
                new SqlParameter("@surcharge", invoiceDetail.Surcharge),
                new SqlParameter("@note", invoiceDetail.Note),
                new SqlParameter("@intoMoney", invoiceDetail.IntoMoney),
                new SqlParameter("@status", invoiceDetail.Status),
                new SqlParameter("@invoiceId", invoiceDetail.Invoice.InvoiceId),
                new SqlParameter("@coachTripId", invoiceDetail.CoachTrip.CoachTripId),
                new SqlParameter("@seatPosition", invoiceDetail.SeatPosition)
            );

            return affected > 0;
        }

        //public static bool DeleteInvoiceDetail(Invoice invoiceId)
        //{
        //    return false;
        //    //string commandText = "Delete from InvoiceDetail where invoiceId = @invoiceId";
        //    //int affected = sqlExecution.ExecuteNonQuery(commandText, CommandType.Text, new SqlParameter("@InvoiceDetailId", InvoiceDetailId));
        //    //return affected > 0;
        //}

        //public static async Task<bool> DeleteInvoiceDetailAsync(Invoice invoiceId)
        //{
        //    return false;
        //    //string commandText = "Delete from InvoiceDetail where invoiceId = @invoiceId";
        //    //int affected =await sqlExecution.ExecuteNonQueryAsync(commandText, CommandType.Text, new SqlParameter("@InvoiceDetailId", InvoiceDetailId));
        //    //return affected > 0;
        //}

        public static int CountInvoiceDetail()
        {
            string commandText = "Select count(*) from InvoiceDetail";
            return (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text);
        }

        public static async Task<int> CountInvoiceDetailAsync()
        {
            string commandText = "Select count(*) from InvoiceDetail";
            return (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text);
        }
    }
}
