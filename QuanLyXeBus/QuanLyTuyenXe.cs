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

namespace QuanLyXeBus
{

    public partial class QuanLyTuyenXe : Form
    {
        public QuanLyTuyenXe()
        {
            InitializeComponent();
            HienThi();
        }
        public void HienThi()
        {
            string str = @"Data Source=DESKTOP-M1G05FS\SQLEXPRESS;Initial Catalog=BusManager;Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string lenh = "select * from Tuyen";
            SqlCommand command = new SqlCommand(lenh, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
            
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

        private void QuanLyTuyenXe_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            string masoxoa = Convert.ToString(dataGridView1.Rows[selectedIndex].Cells[0].Value);
            string query = "Delete from Tuyen where MaTuyen = " + masoxoa;
            string connectionString = @"Data Source=DESKTOP-M1G05FS\SQLEXPRESS;Initial Catalog=BusManager;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandText = query;
            int check = command.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
