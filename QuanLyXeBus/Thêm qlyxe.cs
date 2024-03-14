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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyXeBus
{
    public partial class Thêm : Form
    
    {
        string biensoxe,ckbh;
        int soghe, matuyen;

        int maxe;
        
        public Thêm()
        {
            InitializeComponent();
            AddItemsToComboBox();
            button1.Text = "Lưu";
        }
        public Thêm(DataGridViewRow row )
        {
            InitializeComponent();
            AddItemsToComboBox();
            maxe = Convert.ToInt32(row.Cells[0].Value);

            textBox1.Text = Convert.ToString(row.Cells[1].Value);
            textBox2.Text = Convert.ToString(row.Cells[2].Value);
            textBox3.Text = Convert.ToString(row.Cells[3].Value);
            comboBox2.Text = Convert.ToString(row.Cells[4].Value);
            button1.Text = "Sửa";
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Lưu")
                them();
            else
                sua();
        }
        private void them()
        {
            biensoxe = textBox1.Text;
            soghe = Convert.ToInt32(textBox2.Text);
            ckbh = textBox3.Text;
            matuyen = Convert.ToInt32(comboBox2.Text);
            string connectionStr = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
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
        private void sua()
        {
            biensoxe = textBox1.Text;
            soghe = Convert.ToInt32(textBox2.Text);
            ckbh = textBox3.Text;
            matuyen = Convert.ToInt32(comboBox2.Text);
            string connectionStr = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
            string query = "Update Xe Set BienSo = N'" + biensoxe + "',SoGhe = " + soghe + ",ChuKyBaoHanh = N'" + ckbh + "', MaTuyen = " + matuyen + " where MaXe = " + maxe;

            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandText = query;
            int check = command.ExecuteNonQuery();
            connection.Close();

            if (check > 0)
            {
                MessageBox.Show("Sửa thông tin xe thành công");
            }
            else
            {
                MessageBox.Show("Sửa thông tin xe không thành công");
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItemsToComboBox()
        {
            string connectionString = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";

            string query = "SELECT MaTuyen FROM Tuyen";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader["MaTuyen"].ToString());
                        }
                    }
                }
            }
        }
    }
}
