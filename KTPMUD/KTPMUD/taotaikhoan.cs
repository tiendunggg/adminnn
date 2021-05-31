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

namespace KTPMUD
{
    
    public partial class taotaikhoan : Form
    {
        SqlConnection connection;
        SqlCommand command;

        public taotaikhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                manhinhchinh f = new manhinhchinh();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            {

            }

        }



    }
}
