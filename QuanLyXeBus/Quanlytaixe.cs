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
            command =  connection.CreateCommand();
            command.CommandText = "select * from TaiXe";
            adapter.SelectCommand = command;
            table.Clear();  
            adapter.Fill(table);
            dgv_taixe.DataSource = table;
        }
       
        
        public Quanlytaixe()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void Quanlytaixe_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadDatataixe();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_taixe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
