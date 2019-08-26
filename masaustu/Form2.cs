using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace masaustu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            groupBox1.Left = (Screen.PrimaryScreen.WorkingArea.Width /2)- (groupBox1.Width/2);
            groupBox1.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2)- (groupBox1.Height/2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form13().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form14().Show();
        }
    }
}
