using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeBus
{
    public partial class Form1 : Form
    {
        string hoten, ngaysinh, gioitinh, quequan;
        int xelai;
        int mataixe;
        public Form1()
        {
            InitializeComponent();
            AddItemsToComboBox();
            button1.Text = "Lưu";
        }
        public Form1(DataGridViewRow row)
        {
            InitializeComponent();
            AddItemsToComboBox();
            button1.Text = "Sửa";
            mataixe =Convert.ToInt32( row.Cells[0].Value);

            textBox2.Text = Convert.ToString(row.Cells[1].Value);
            dateTimePicker2.Text = row.Cells[2].Value.ToString();
            comboBox1.Text = Convert.ToString(row.Cells[3].Value);
            textBox4.Text = Convert.ToString(row.Cells[4].Value);
            comboBox2.Text = Convert.ToString(row.Cells[5].Value);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Sửa") sua();
            else them();
        }
        private void them()
        {
            hoten = textBox2.Text;
            ngaysinh = dateTimePicker2.Value.ToString("d");
            gioitinh = comboBox1.Text;
            quequan = textBox4.Text;
            xelai = Convert.ToInt32(comboBox2.Text);
            string connectionString = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
            string query = "insert into TaiXe values (N'" + hoten + "',N'" + ngaysinh + "',N'" + gioitinh + "',N'" + quequan + "'," + xelai + ")";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandText = query;
            int check = command.ExecuteNonQuery();

            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Thêm tài xế thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài xế thất bại");
            }
            this.Close();
        }
        private void sua()
        {
            hoten = textBox2.Text;
            ngaysinh = dateTimePicker2.Value.ToString("d");
            gioitinh = comboBox1.Text;
            quequan = textBox4.Text;
            xelai = Convert.ToInt32(comboBox2.Text);
            string connectionString = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
            string query = "update TaiXe set TenTaiXe = N'" + hoten + "',NgaySinh = N'" + ngaysinh + "',GioiTinh = N'" + gioitinh + "',QueQuan = N'" + quequan + "',XeLai = " + xelai + "where MaTaiXe = "+mataixe;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandText = query;
            int check = command.ExecuteNonQuery();

            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Sửa tài xế thành công");
            }
            else
            {
                MessageBox.Show("Sửa tài xế thất bại");
            }
            this.Close();
        }
        private void AddItemsToComboBox()
        {
            string connectionString = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";

            string query = "SELECT MaXe FROM Xe";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader["MaXe"].ToString());
                        }
                    }
                }
            }
        }
    }
}
