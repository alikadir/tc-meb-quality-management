using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace masaustu
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();

            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pictureBox1.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (pictureBox1.Width / 2);
            pictureBox1.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (pictureBox1.Height / 2);

        }

        private void Form0_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
