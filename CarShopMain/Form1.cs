﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopMain
{
    public partial class Form1 : Form
    {
        ArrayList myCars = new ArrayList();
        AddCarsToList Add = new AddCarsToList();
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Add Car";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Add.Show();
        }
    }
}
