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
    public partial class frmHopDong : Form
    {
        KetNoiCSDL ketNoi = new KetNoiCSDL();
        public frmHopDong()
        {
            InitializeComponent();
        }

        void loadData()
        {
            string str = "select * from HopDongThueXe";
            dtgHopDong.DataSource = ketNoi.Execute(str);
        }

        private void lblMaKH_Click(object sender, EventArgs e)
        {

        }

        private void lblMaXe_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayThue_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayTra_Click(object sender, EventArgs e)
        {

        }

        private void lblMaHopDong_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayTraThat_Click(object sender, EventArgs e)
        {

        }

        private void lblThoiGianThue_Click(object sender, EventArgs e)
        {

        }

        private void lblTongChiPhi_Click(object sender, EventArgs e)
        {

        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
