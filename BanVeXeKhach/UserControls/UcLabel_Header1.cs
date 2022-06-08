using System.Windows.Forms;

namespace BanVeXeKhach.UserControls
{
    public partial class UcLabel_Header1 : UserControl
    {
        public UcLabel_Header1()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            lbMain.Text = text;
        }
    }
}
