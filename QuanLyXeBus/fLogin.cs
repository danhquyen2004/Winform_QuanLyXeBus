using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyXeBus
{
    public partial class fLogin : Form
    {
        List<User> users = new List<User> ();
        public fLogin()
        {
            InitializeComponent();
            users = GetUserFromDB();
            textBox1.Text = "User name";
            textPassword.Text = "Password";
            label8.Text = "";
            textPassword.UseSystemPasswordChar = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textPassword.Text;

            foreach (var user in users)
            {
                if (user.userName == username)
                {
                    if (user.password == password)
                    {
                        label8.Text = "";
                        fMainManager f = new fMainManager();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        return;
                    }
                }
                label8.Text = "User name or password is incorrect";
            }
        }


        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn thoát?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "User name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void textPassword_Click(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = true;
            if (textPassword.Text == "Password")
            {
                textPassword.Text = "";
                textPassword.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "User name";
                textBox1.ForeColor = System.Drawing.Color.FromArgb(206, 209, 216);
            }

        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.ForeColor = System.Drawing.Color.FromArgb(206, 209, 216);
                textPassword.Text = "Password";
                textPassword.UseSystemPasswordChar = false;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private List<User> GetUserFromDB()
        {
            List<User> users = new List<User>();
            string connectionStr = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True";
            string query = "Select TenTK,MatKhau,ChucVu from NhanVien";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user.userName = reader["TenTK"].ToString();
                user.password = reader["MatKhau"].ToString();
                user.role = Convert.ToInt32(reader["ChucVu"]);
                users.Add(user);
            }
            connection.Close();
            return users;
        }

    }
}
