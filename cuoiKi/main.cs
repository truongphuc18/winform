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
    public partial class frmMain : Form
    {
       
        public frmMain()
        {
            InitializeComponent();
        }

        

        private void tìmXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfoKH frmInfoKH = new frmInfoKH();
            frmInfoKH.Show();
        }

        private void mnuXeTrong_Click(object sender, EventArgs e)
        {
            frmDSXeTrong frmDSXeTrong = new frmDSXeTrong();
            frmDSXeTrong.Show();
        }

        private void mnuXeDaChoThue_Click(object sender, EventArgs e)
        {
            frmDSXeDangChoThue frmDSXeDangChoThue = new frmDSXeDangChoThue();
            frmDSXeDangChoThue.Show();
        }

        private void mnuXeHong_Click(object sender, EventArgs e)
        {
            frmXeHong frmXeHong = new frmXeHong(); 
            frmXeHong.Show();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLienHe frmLienHe = new frmLienHe();
            frmLienHe.Show();
        }

        private void mnuHopDongThue_Click(object sender, EventArgs e)
        {
            frmHopDong frmHopDong = new frmHopDong();
            frmHopDong.Show();
        }
    }
}
