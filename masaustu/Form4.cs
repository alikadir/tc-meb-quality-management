using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace masaustu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
              groupBox1.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (groupBox1.Width / 2);
            groupBox1.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (groupBox1.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 x = new Form5();
            x.Show();
        }
    }
}
