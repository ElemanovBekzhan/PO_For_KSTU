﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Podrazdeleniya_komp podrazdeleniyaKomp = new Podrazdeleniya_komp();
            podrazdeleniyaKomp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Founders founders = new Founders();
            founders.Show();
        }
    }
}