using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace masaustu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            panel2.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (panel2.Width / 2);
            panel2.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (panel2.Height / 2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                panel1.Visible = true;
            else
                panel1.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                listBox1.Visible = true;
            else
                listBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 x = new Form4();
            x.Show();
        }

   
    }
}
