using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuoiKi
{
    public partial class frmLogin : Form
    {
        string connectionString = "Data Source=DESKTOP-72FN29C\\SQLEXPRESS;Initial Catalog=QLdichvuthuexe;Integrated Security=True;Encrypt=False";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;

            frmMain frmMain = new frmMain();

            string sql = "SELECT * FROM DANGNHAP WHERE Username = @user  AND pass = @pass";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        frmMain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!");
                    }

                    reader.Close();
                }
            }

            }
    }
}
