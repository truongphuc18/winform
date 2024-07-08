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
    public partial class frmDSXeTrong : Form
    {
        KetNoiCSDL ketNoi = new KetNoiCSDL();
        public frmDSXeTrong()
        {
            InitializeComponent();
        }
        

        
        private void frmDSXeTrong_Load(object sender, EventArgs e)
        {
            string str = "select * from DanhSachXe where TinhTrang = N'Sẵn sàng'";
            dtgXeTrong.DataSource = ketNoi.Execute(str);
        }



    }
}
