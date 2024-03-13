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
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNhanVien form = new ThemNhanVien();
            form.ShowDialog();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {

        }
        private void LoadNhanVien()
        {
            string query = "select * from NhanVien";
            string connectionString = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True";
            DataProvider.Instance.SetConnectionString(connectionString);
            dataGridView1.DataSource =  DataProvider.Instance.DataTableByQuery(query);
        }
    }
}
