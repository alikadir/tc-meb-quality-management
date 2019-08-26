using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace masaustu
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        void OneriDoldur()
        {
            if (listBox4.Items.Count < 1)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Tanımlı Öneri Yok");
                listBox4.Enabled = false;
                button2.Enabled = false;

            }


            else
            {
                listBox4.Items.Remove("Tanımlı Öneri Yok");
                listBox4.Enabled = true;


            }


            if (listBox5.Items.Count < 1)
            {
                listBox5.Items.Clear();
                listBox5.Items.Add("Tanımlı Öneri Yok");
                listBox5.Enabled = false;
                button2.Enabled = false;


            }
            else
            {

                listBox5.Items.Remove("Tanımlı Öneri Yok");
                listBox5.Enabled = true;



            }
            if (listBox6.Items.Count < 1)
            {
                listBox6.Items.Clear();
                listBox6.Items.Add("Tanımlı Öneri Yok");
                button2.Enabled = false;

                listBox6.Enabled = false;
            }
            else
            {


                listBox6.Items.Remove("Tanımlı Öneri Yok");
                listBox6.Enabled = true;


            }

            if (!(listBox4.Items.Count < 1) && !(listBox5.Items.Count < 1) && !(listBox5.Items.Count < 1))
            {


                button2.Enabled = true;


            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((listBox4.SelectedItems.Count > 0))
            {

                listBox4.Items.Remove(listBox4.SelectedItem.ToString());
            }
            else if ((listBox5.SelectedItems.Count > 0))
            {

                listBox5.Items.Remove(listBox5.SelectedItem.ToString());

            }
            else if ((listBox6.SelectedItems.Count > 0))
            {
                listBox6.Items.Remove(listBox6.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Öneriyi Seçiniz ");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (
              (radioButton4.Checked || radioButton5.Checked || radioButton6.Checked)
              && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text)
              )
            {

                if (radioButton4.Checked)
                {
                    listBox4.Items.Add(textBox4.Text + " - " + textBox3.Text + " - " + comboBox1.SelectedItem.ToString());
                }
                else if (radioButton5.Checked)
                {
                    listBox5.Items.Add(textBox4.Text + " - " + textBox3.Text + " - " + comboBox1.SelectedItem.ToString());
                }
                else if (radioButton6.Checked)
                {
                    listBox6.Items.Add(textBox4.Text + " - " + textBox3.Text + " - " + comboBox1.SelectedItem.ToString());
                }

                textBox3.Text = "";
                textBox4.Text = "";

                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;

                OneriDoldur();
            }
            else
            {
                MessageBox.Show("Alanları tam Doldurunuz!");
            }
        }
    }
}
