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
    public partial class ListMyCars : Form
    {
        public ArrayList myBootyCars = new ArrayList();
        public ListMyCars()
        {
            InitializeComponent();
            myBootyCars.Add(new CarObject() { model = "Volvo 740", number = "346827384783", prise = 120000});
            myBootyCars.Add(new CarObject() { model = "Volvo 260", number = "824494564235", prise = 200000});
            foreach (CarObject bil in myBootyCars)
            {
                listBox1.Items.Add(bil);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Jag är en {0}", listBox1.SelectedItem.GetType().Name));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
