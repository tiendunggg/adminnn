using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPMUD
{
    public partial class quanlinguoidung : Form
    {
        public quanlinguoidung()
        {
            InitializeComponent();
        }

        private void buttoncapnhat_Click(object sender, EventArgs e)
        {
            datanguoidung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datanguoidung.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datanguoidung.DataSource = GetAlldanhsachnguoidung().Tables[0];

            //datanguoidung.DataMember = "danhsachnguoidung";
        }

        DataSet GetAlldanhsachnguoidung()
        {
            DataSet data = new DataSet();
            string query = " select * from danhsachnguoidung";
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();

            }    
            return data;
        }


    }
}


