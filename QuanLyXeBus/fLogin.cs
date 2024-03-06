using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyXeBus
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            textBox1.Text = "User name";
            textPassword.Text = "Password";
            textPassword.UseSystemPasswordChar = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fMainManager f = new fMainManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn thoát?","Thông Báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
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
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "User name")
                textBox1.Text = "";
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void textPassword_Click(object sender, EventArgs e)
        {
            if(textPassword.Text == "Password")
            {
                textPassword.Text = "";
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
                textBox1.Text = "User name";
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "Password";
                textPassword.UseSystemPasswordChar = false;
            }
                
        }
    }
}
