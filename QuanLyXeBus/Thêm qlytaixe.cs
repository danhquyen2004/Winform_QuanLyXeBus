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
using System.Data.SqlClient;

namespace QuanLyXeBus
{
    public partial class Form1 : Form
    {
        string  hoten, ngaysinh, gioitinh, quequan, xelai;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hoten = textBox2.Text;
            ngaysinh = dateTimePicker2.Text;
            gioitinh = comboBox1.Text;
            quequan = textBox4.Text;
            xelai = comboBox2.Text;
            string connectionString = "Data Source=LAPTOP-N9ELN8MN\\SQLEXPRESS01;Initial Catalog=QuanLyXeBus;Integrated Security=true";
            string query = "insert into TaiXe values (N'" + hoten + "',N'" + ngaysinh + "',N'" + gioitinh + "',N'" + quequan + "',N'" + xelai + "')";

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
    }
}
