using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeBus
{
    public partial class QuanLyTuyenXe : Form
    {
        public QuanLyTuyenXe()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemQLTX them = new ThemQLTX();
            them.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemQLTX them = new ThemQLTX();
            them.ShowDialog();
        }
    }
}
