using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace masaustu
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            OneriDoldur();

            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;

        }
        void OneriDoldur()
        {
            if (listBox1.Items.Count < 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Tanımlı Öneri Yok");
                listBox1.Enabled = false;
                button3.Enabled = false;
              
            }
          
            
               else
            {
                listBox1.Items.Remove("Tanımlı Öneri Yok");
                listBox1.Enabled = true;

         
            }
            
           
             if (listBox2.Items.Count < 1)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Tanımlı Öneri Yok");
                listBox2.Enabled = false;
                button3.Enabled = false;
              
                
            }
             else
             {
                
                 listBox2.Items.Remove("Tanımlı Öneri Yok");
                 listBox2.Enabled = true;

                
               
             }
             if (listBox3.Items.Count < 1)
            {
                listBox3.Items.Clear();
                listBox3.Items.Add("Tanımlı Öneri Yok");
                button3.Enabled = false;
              
                listBox3.Enabled = false;
            }
             else
            {
               

                listBox3.Items.Remove("Tanımlı Öneri Yok");
                listBox3.Enabled = true;

               
            }

             if (!(listBox1.Items.Count < 1) && !(listBox2.Items.Count < 1) && !(listBox3.Items.Count < 1))
             {


                 button3.Enabled = true;
              
               
             }
        
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pnl1.Visible = true;

            button3.Enabled = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedItems.Count > 0))
            {

                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            }
            else if ((listBox2.SelectedItems.Count > 0))
            {

                listBox2.Items.Remove(listBox2.SelectedItem.ToString());

            }
            else if ((listBox3.SelectedItems.Count > 0))
            {
                listBox3.Items.Remove(listBox3.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Öneriyi Seçiniz ");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
                && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text)
                )
            {

                if (radioButton1.Checked)
                {
                    listBox1.Items.Add(textBox2.Text + " - " + textBox1.Text);
                }
                else if (radioButton2.Checked)
                {
                    listBox2.Items.Add(textBox2.Text + " - " + textBox1.Text);
                }
                else if (radioButton3.Checked)
                {
                    listBox3.Items.Add(textBox2.Text + " - " + textBox1.Text);
                }

                textBox1.Text = "";
                textBox2.Text = "";

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;

                OneriDoldur();
            }
            else
            {
                MessageBox.Show("Alanları tam Doldurunuz!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form8 x = new Form8();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 x = new Form9();
            x.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 x = new Form11();
            x.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form12().Show();
        }

      
       

        
    }
    
}
