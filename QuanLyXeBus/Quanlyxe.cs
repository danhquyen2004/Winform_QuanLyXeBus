﻿using System;
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
    public partial class Quanlyxe : Form
    {
        public Quanlyxe()
        {
            InitializeComponent();
        }

        private void Quanlyxe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quanlyxe them = new Quanlyxe();
            them.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quanlyxe them = new Quanlyxe();
            them.ShowDialog();
        }
    }
}
