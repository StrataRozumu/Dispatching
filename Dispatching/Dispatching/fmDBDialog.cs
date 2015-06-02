﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dispatching
{
    public partial class fmDBDialog : Form
    {
        public fmDBDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "" ||
                comboBox2.Text == "" ||
                textBox1.Text == "" ||
                textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else{
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
