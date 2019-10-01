using System;
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
    public partial class AddCarsToList : Form
    {
        public AddCarsToList()
        {
            InitializeComponent();
            button1.Text = "Add Car to Storage";
            button2.Text = "Close";
            label1.Text = "Store away your car here";
            label2.Text = "Model";
            label3.Text = "HorsePower";
            label4.Text = "Max Speed";
            label5.Text = "Registration-number";
            label6.Text = "Prise";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                listBox1.Items.Add("Hello");
                //myCars.Add(new CarObject() {
                //    model = textBox1.Text, 
                //    horsePower = int.Parse(textBox2.Text), 
                //    maxSpeed = int.Parse(textBox3.Text), 
                //    number = textBox4.Text, 
                //    prise = int.Parse(textBox5.Text)});
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Please fill in all lines of");
                listBox1.Items.Add("information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
