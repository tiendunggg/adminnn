using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPMUD
{
    public partial class manhinhchinh : Form
    {
        public manhinhchinh()
        {
            InitializeComponent();
        }

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlinguoidung f = new quanlinguoidung();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
