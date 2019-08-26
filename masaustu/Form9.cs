using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace masaustu
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            listBox7.Items.Clear();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(comboBox2.SelectedItem.ToString() + " - " + textBox5.Text);
        }
    }
}
