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

        int ma;
        DataGridViewRow row;
        public ThemNhanVien()
        {
            InitializeComponent();
            button1.Text = "Lưu";
        }
        public ThemNhanVien(DataGridViewRow row)
        {
            InitializeComponent();
            ma = Convert.ToInt32(row.Cells[1].Value);
            textBox2.Text = Convert.ToString(row.Cells[3].Value);
            dateTimePicker2.Text = row.Cells[6].Value.ToString();
            textBox3.Text = Convert.ToString(row.Cells[0].Value);
            textBox4.Text = Convert.ToString(row.Cells[2].Value);
            textBox1.Text = Convert.ToString(row.Cells[4].Value);
            comboBox1.Text = Convert.ToInt32(row.Cells[5].Value) == 0 ? Convert.ToString(comboBox1.Items[1]) :
                                                                        Convert.ToString(comboBox1.Items[0]);
            button1.Text = "Sửa";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Lưu")
                Add();
            else
                Update();
        }

        private void Add()
        {
            hoten = textBox2.Text;
            ngaysinh = dateTimePicker2.Value.ToString("d");
            tentk = textBox3.Text;
            matkhau = textBox4.Text;
            lienlac = textBox1.Text;
            chucvu = comboBox1.Text == "Admin" ? 0 : 1;
            string connectionStr = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
            string query = "insert into NhanVien values (N'" + tentk + "',N'" + matkhau + "',N'" + hoten + "', N'" + lienlac + "'," + chucvu + ",'" + ngaysinh + "')";

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
        private void Update()
        {
            hoten = textBox2.Text;
            ngaysinh = dateTimePicker2.Value.ToString("d");
            tentk = textBox3.Text;
            matkhau = textBox4.Text;
            lienlac = textBox1.Text;
            chucvu = comboBox1.Text == "Admin" ? 0 : 1;
            string connectionStr = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
            string query = "Update NhanVien Set TenTK = N'" + tentk + "',MatKhau = N'" + matkhau + "',HoTen = N'" + hoten + "', LienLac = N'" + lienlac + "',ChucVu = " + chucvu + ",NgaySinh = '" + ngaysinh + "' where MaTK = "+ma;

            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandText = query;
            int check = command.ExecuteNonQuery();
            connection.Close();


            if (check > 0)
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");
            this.Close();
        }
    }
}
