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
        public ThemQLTX()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //them
            ten = textBox1.Text;
            luotdi = textBox9.Text;
            luotve = textBox10.Text;
            giancach = Convert.ToInt32( textBox4.Text);
            string lenh = "insert into	Tuyen values(N'"+ten+"',"+giancach+", N'"+luotdi+"', N'"+luotve+"')";

            string str = @"Data Source=DESKTOP-M1G05FS\SQLEXPRESS;Initial Catalog=BusManager;Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand command = new SqlCommand(lenh, connection);
            command.CommandText = lenh;
            int check = command.ExecuteNonQuery();
            connection.Close();

            if(check > 0)
            {
                MessageBox.Show("Thêm Tuyến Xe thành công!");
            }
            else
            {
                MessageBox.Show("Thêm Tuyến Xe thất bại!");
            }
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

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
    }
}
