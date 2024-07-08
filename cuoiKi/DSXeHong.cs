using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuoiKi
{
    public partial class frmXeHong : Form
    {
        KetNoiCSDL ketNoi = new KetNoiCSDL();
        public frmXeHong()
        {
            InitializeComponent();
        }

        private void frmXeHong_Load(object sender, EventArgs e)
        {
            string str = "select * from DanhSachXe where TinhTrang = N'Bảo trì'";
            dtgXeHong.DataSource = ketNoi.Execute(str);
        }
    }
}
