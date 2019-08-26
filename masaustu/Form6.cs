using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace masaustu
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            panel1.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (panel1.Width / 2);
            panel1.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (panel1.Height / 2);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add("Tanımlanmış Öğretmen Yok");
                listBox1.Enabled = false;
            }
            else
            {
                listBox1.Enabled = true;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                listBox1.Items.Remove("Tanımlanmış Öğretmen Yok");
                listBox1.Items.Add(textBox1.Text + " - " + textBox2.Text);
                groupBox2.Visible = false;
                button1.Enabled = true;
                listBox1.Enabled = true;
                button5.Enabled = true;


            }
            else
            {
                MessageBox.Show("Tüm alanları doldurun!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 x = new Form7();
            x.Show();
        }

    }
}
