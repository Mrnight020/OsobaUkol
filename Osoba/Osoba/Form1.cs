﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osoba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pacient pepa = new Pacient((float)numericUpDown3.Value,textBox1.Text,textBox2.Text,(float)numericUpDown1.Value,(float)numericUpDown2.Value);
            MessageBox.Show("" + pepa.ToString());
            /*MessageBox.Show("tvoje ABSI je :" + pepa.ABSI());
            MessageBox.Show("" + pepa.ToString());*/

        }
    }
}
