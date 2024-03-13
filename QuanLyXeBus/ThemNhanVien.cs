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
    public partial class ThemNhanVien : Form
    {
        string hoten,ngaysinh, tentk, matkhau, lienlac;
        int chucvu;
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hoten = textBox2.Text;
            ngaysinh = dateTimePicker2.Value.ToString("d");
            tentk = textBox3.Text;
            matkhau = textBox4.Text;
            lienlac = textBox1.Text;
            chucvu = comboBox1.Text == "Admin" ? 0 : 1;
            string connectionStr = @"Data Source=DESKTOP-M1G05FS\SQLEXPRESS;Initial Catalog=BusManager;Integrated Security=True";
            string query = "insert into NhanVien values (N'"+tentk+"',N'"+matkhau+"',N'"+hoten+"', N'"+lienlac+"',"+chucvu+",'"+ngaysinh+"')";

            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandText = query;
            int check = command.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
                MessageBox.Show("Thêm nhân viên thành công!");
            else
                MessageBox.Show("Thêm nhân viên thất bại!");
            this.Close();
        }
    }
}
