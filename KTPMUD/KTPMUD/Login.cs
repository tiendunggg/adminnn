using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace KTPMUD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)


        {
            Application.Exit();


        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection (@"Data Source=DESKTOP-8SMHBV9\DUNG;Initial Catalog=KTPMUD;Integrated Security=True");
            
            {
                connection.Open();
                string Email = textBoxusername.Text;
                string matkhau = textBoxmatkhau.Text;
                string sql = "select * from danhsachnguoidung where Email = '" + Email + "' and Password = '" + matkhau + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    manhinhchinh f = new manhinhchinh();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("ĐĂNG NHẬP THẤT BẠI");
                }

            }
        }

        private void taotaikhoan_Click(object sender, EventArgs e)
        {
            taotaikhoan f = new taotaikhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quenmatkhau_Click(object sender, EventArgs e)
        {
            quenmatkhau f = new quenmatkhau();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
        
    }

