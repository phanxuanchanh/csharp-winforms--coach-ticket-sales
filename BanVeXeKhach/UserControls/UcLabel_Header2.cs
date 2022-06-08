using System.Drawing;
using System.Windows.Forms;

namespace BanVeXeKhach.UserControls
{
    public partial class UcLabel_Header2 : UserControl
    {
        public UcLabel_Header2()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            lbMain.Text = text;
        }

        public void SetImage(Image image)
        {
            pbMain.Image = image;
        }
    }
}
