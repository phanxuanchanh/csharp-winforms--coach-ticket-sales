using BanVeXeKhach.BUS_DAO.BUS;

namespace BanVeXeKhach.Session
{
    public static class CustomerSession
    {
        public static Customer SellTicket_SelectedCustomer { get; set; }
        public static string CancelTicket_SelectedCustomer { get; set; }
    }
}
