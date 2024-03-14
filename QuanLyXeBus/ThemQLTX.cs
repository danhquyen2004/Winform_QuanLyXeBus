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
    public partial class ThemQLTX : Form
    {
        string ten, luotdi, luotve;
        int giancach;
        int MaTuyen;
        public ThemQLTX()
        {
            InitializeComponent();
            button1.Text = "Lưu";
        }
        public ThemQLTX(DataGridViewRow row)
        {
            InitializeComponent();
            MaTuyen = Convert.ToInt32(row.Cells[0].Value);

            textBox1.Text = Convert.ToString(row.Cells[1].Value);
            textBox4.Text = Convert.ToString(row.Cells[2].Value);
            textBox9.Text = Convert.ToString(row.Cells[3].Value);
            textBox10.Text = Convert.ToString(row.Cells[4].Value);

            button1.Text = "Sửa";
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Lưu")
                Them();
            else
                Sua();

        }

        private void ThemQLTX_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        public void Sua()
        {
            ten = textBox1.Text;
            luotdi = textBox9.Text;
            luotve = textBox10.Text;
            giancach = Convert.ToInt32(textBox4.Text);
            string lenh = "update Tuyen set TenTuyen = N'" + ten + "',GianCach = " + giancach + ", LTLuotDi = N'" + luotdi + "', LTLuotVe =  N'" + luotve + "' where MaTuyen = " + MaTuyen;

            string str = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand command = new SqlCommand(lenh, connection);
            command.CommandText = lenh;
            int check = command.ExecuteNonQuery();
            connection.Close();

            if (check > 0)
            {
                MessageBox.Show("Sửa Tuyến Xe thành công!");
            }
            else
            {
                MessageBox.Show("Sửa Tuyến Xe thất bại!");
            }
            this.Close();
        }
        public void Them()
        {
            ten = textBox1.Text;
            luotdi = textBox9.Text;
            luotve = textBox10.Text;
            giancach = Convert.ToInt32(textBox4.Text);
            string lenh = "insert into	Tuyen values(N'" + ten + "'," + giancach + ", N'" + luotdi + "', N'" + luotve + "')";

            string str = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand command = new SqlCommand(lenh, connection);
            command.CommandText = lenh;
            int check = command.ExecuteNonQuery();
            connection.Close();

            if (check > 0)
            {
                MessageBox.Show("Thêm Tuyến Xe thành công!");
            }
            else
            {
                MessageBox.Show("Thêm Tuyến Xe thất bại!");
            }
            this.Close();
        }
    }
}