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
    public partial class Thêm : Form
    
    {
        string biensoxe,ckbh;
        int soghe, matuyen;
        
        public Thêm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Thêm_Load(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            biensoxe = textBox1.Text;
            soghe = Convert.ToInt32(textBox2.Text);
            ckbh = textBox3.Text;
            matuyen = Convert.ToInt32(comboBox2.Text);
            string connectionStr = @"Data Source=DESKTOP-LNGJ4BJ\SQLEXPRESS;Initial Catalog=BusManager;Integrated Security=True";
            string query = "insert into Xe values (N'" + biensoxe + "'," + soghe + ",N'" + ckbh + "'," + matuyen + ") ";

            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandText = query;
            int check = command.ExecuteNonQuery();
            connection.Close();

            if (check > 0)
            {
                MessageBox.Show("Thêm xe thành công");
            }
            else
            {
                MessageBox.Show("Thêm xe không thành công");
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
