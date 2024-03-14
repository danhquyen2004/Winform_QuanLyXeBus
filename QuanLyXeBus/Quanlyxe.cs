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
    public partial class Quanlyxe : Form
    {
        public Quanlyxe()
        {
            InitializeComponent();
            Hienthi();
        }
        public void Hienthi()
        {
            string chuoi = "Data Source=DESKTOP-LNGJ4BJ\\SQLEXPRESS;Initial Catalog=BusManager;Integrated Security=True";
            SqlConnection connection = new SqlConnection(chuoi);
            connection.Open();
            string lenh = "select * from Xe";
            SqlCommand sqlCommand = new SqlCommand(lenh, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
            
        }

        

        private void Quanlyxe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thêm them = new Thêm();
            them.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thêm them = new Thêm();
            them.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            string masoxoa = Convert.ToString(dataGridView1.Rows[selectedIndex].Cells[0].Value);
            string query = "Delete from Xe where MaXe = " + masoxoa;
            string connectionString = "Data Source=DESKTOP-LNGJ4BJ\\SQLEXPRESS;Initial Catalog=BusManager;Integrated Security=True";
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
    }
}
