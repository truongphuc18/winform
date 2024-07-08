using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace cuoiKi
{
    public partial class frmInfoKH : Form
    {
        KetNoiCSDL ketNoi = new KetNoiCSDL();
        
        public frmInfoKH()
        {
            InitializeComponent();
        }

       

        void loadData()
        {
            string str = "select * from KhachHang ";
            dtgInfoKH.DataSource = ketNoi.Execute(str);
        }

        private void frmInfoKH_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            string name = txtTenKH.Text;
            string sdt = txtSDT.Text;
            string address = txtDiaChi.Text;
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            DateTime dateTime = dtpNgaySinh.Value;


            string qr = "insert into KhachHang values('"+cmnd+"',N'"+name+"', '"+dateTime+"',N'"+gioitinh+"',N'"+address+"',N'"+sdt+"')";
            ketNoi.ExecuteNonQuery(qr );
            MessageBox.Show("Thêm thành công !", "Thông báo");
            loadData();


            txtCMND.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Today;
            


        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if (rdTimMAKH.Checked)
            {
                string timKiemMAKH = txtTimKiem.Text;
                int id = Convert.ToInt32(timKiemMAKH);
                string query = "select * from KhachHang where MaKhachHang = " + timKiemMAKH;
                DataTable dt = ketNoi.Execute(query);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thấy khách hàng với Mã khách hàng : " + timKiemMAKH, "Thông báo");
                    dtgInfoKH.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                }
            }

            if (rdTimCMND.Checked)
            {
                string timKiemCMND = txtTimKiem.Text;
                int id = Convert.ToInt32(timKiemCMND);
                string query = "select * from KhachHang where SoCMND = " + timKiemCMND;
                DataTable dt = ketNoi.Execute(query);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thấy khách hàng với Số CMND : " + timKiemCMND, "Thông báo");
                    dtgInfoKH.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                }
            }







        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadData();
            rdTimMAKH.Checked  = false;
            rdTimCMND.Checked = false;
            rdTimTen.Checked = false;
            txtTimKiem.Text = "";
            
        }
    }
}




    
