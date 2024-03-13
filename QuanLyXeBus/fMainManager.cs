using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeBus
{
    public partial class fMainManager : Form
    {
        public fMainManager()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenForm(Form childForm)
        {
            if (currentFormChild != null) { currentFormChild.Close(); }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelbody.Controls.Add(childForm);
            panelbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void fMainManager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            OpenForm(new QLNhanVien());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new QuanLyDonVi());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            OpenForm(new Quanlytaixe());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            OpenForm(new QuanLyTuyenXe());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            OpenForm(new Quanlyxe());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm(new vexe());
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Bisque;
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Bisque;
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Bisque;
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Bisque;
        }
    }
}
