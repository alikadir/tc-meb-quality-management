using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace masaustu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            groupBox1.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (groupBox1.Width / 2);
            groupBox1.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (groupBox1.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "tatlimustafa@hotmail.com" && textBox2.Text == "ekalite")
            {
                Form2 x = new Form2();
                x.Show();
                Form1 y = new Form1();
                y.Hide();
            }
            else
                MessageBox.Show("Girilen şifre hatalı");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bölüm il ilçe milli eğitim müdürlüğünce kullanılmaktadır", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kıyaslama yapmak için kurum bilgilerinizi tanımlayınız", "Tanımlama Yapınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
