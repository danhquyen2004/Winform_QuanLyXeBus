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
    public partial class Quanlytaixe : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-N9ELN8MN\\SQLEXPRESS01;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadDatataixe()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TaiXe";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        public Quanlytaixe()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadDatataixe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_taixe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Quanlytaixe_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadDatataixe();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            string masoxoa = Convert.ToString(dataGridView1.Rows[selectedIndex].Cells[0].Value);
            string query = "Delete from TaiXe where MaTaiXe = " + masoxoa;
            string connectionString = "Data Source=LAPTOP-N9ELN8MN\\SQLEXPRESS01;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
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
