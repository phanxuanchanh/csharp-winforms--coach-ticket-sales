using BanVeXeKhach.BUS_DAO.DAO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.BUS
{
    public class InvoiceDetail
    {
        private Invoice invoice;
        private CoachTrip coachTrip;
        private int seatPosition;
        private double price;
        private double surcharge;
        private string note;
        private double intoMoney;
        private string status;

        public Invoice Invoice { get => invoice; set => invoice = value; }
        public CoachTrip CoachTrip { get => coachTrip; set => coachTrip = value; }
        public int SeatPosition { get => seatPosition; set => seatPosition = value; }
        public double Price { get => price; set => price = value; }
        public double Surcharge { get => surcharge; set => surcharge = value; }
        public string Note { get => note; set => note = value; }
        public double IntoMoney { get => intoMoney; set => intoMoney = value; }
        public string Status { get => status; set => status = value; }

        public static List<InvoiceDetail> GetInvoiceDetails(long invoiceId)
        {
            return InvoiceDetailDAO.GetInvoiceDetails(invoiceId);
        }

        public static async Task<List<InvoiceDetail>> GetInvoiceDetailsAsync(long invoiceId)
        {
            return await InvoiceDetailDAO.GetInvoiceDetailsAsync(invoiceId);
        }

        public static List<int> GetSelectedSeatsByCoachTripId(long coachTripId)
        {
            return InvoiceDetailDAO.GetSelectedSeatByCoachTripId(coachTripId);
        }

        public static async Task<List<int>> GetSelectedSeatsByCoachTripIdAsync(long coachTripId)
        {
            return await InvoiceDetailDAO.GetSelectedSeatByCoachTripIdAsync(coachTripId);
        }

        public static bool CreateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            return InvoiceDetailDAO.CreateInvoiceDetail(invoiceDetail);
        }

        public static async Task<bool> CreateInvoiceDetailAsync(InvoiceDetail invoiceDetail)
        {
            return await InvoiceDetailDAO.CreateInvoiceDetailAsync(invoiceDetail);
        }

        public bool UpdateInvoiceDetail()
        {
            return InvoiceDetailDAO.UpdateInvoiceDetail(this);
        }

        public async Task<bool> UpdateInvoiceDetailAsync()
        {
            return await InvoiceDetailDAO.UpdateInvoiceDetailAsync(this);
        }

        //public bool DeleteInvoiceDetail()
        //{
        //    return InvoiceDetailDAO.DeleteInvoiceDetail(InvoiceId);
        //}

        //public static async Task<bool> DeleteInvoiceDetailAsync()
        //{
        //    return await InvoiceDetailDAO.DeleteInvoiceDetailAsync(Invoice.InvoiceId);
        //}

        public static int CountInvoiceDetail()
        {
            return InvoiceDetailDAO.CountInvoiceDetail();
        }

        public static async Task<int> CountInvoiceDetailAsync()
        {
            return await InvoiceDetailDAO.CountInvoiceDetailAsync();
        }

    }
}
