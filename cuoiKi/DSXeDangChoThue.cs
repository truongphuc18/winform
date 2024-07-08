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
    public partial class frmDSXeDangChoThue : Form
    {
        KetNoiCSDL ketNoi = new KetNoiCSDL();
        public frmDSXeDangChoThue()
        {
            InitializeComponent();
        }

        private void frmDSXeDangChoThue_Load(object sender, EventArgs e)
        {
            string str = "select * from DanhSachXe where TinhTrang = N'Đang sử dụng'";
            dtgXeDangChoThue.DataSource = ketNoi.Execute(str);
        }
    }
}
