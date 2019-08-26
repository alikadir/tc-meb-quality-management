namespace masaustu
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlOdul = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.PnlOdul.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlOdul
            // 
            this.PnlOdul.Controls.Add(this.textBox5);
            this.PnlOdul.Controls.Add(this.button5);
            this.PnlOdul.Controls.Add(this.comboBox2);
            this.PnlOdul.Controls.Add(this.label15);
            this.PnlOdul.Controls.Add(this.label14);
            this.PnlOdul.Controls.Add(this.listBox7);
            this.PnlOdul.Location = new System.Drawing.Point(174, 100);
            this.PnlOdul.Name = "PnlOdul";
            this.PnlOdul.Size = new System.Drawing.Size(600, 181);
            this.PnlOdul.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(375, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 20);
            this.textBox5.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(421, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Takdir",
            "Teşekkür",
            "Maaş ile Ödüllendirme",
            "Plaket"});
            this.comboBox2.Location = new System.Drawing.Point(373, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(321, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "İsim";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Ödül tipi";
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(3, 3);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(283, 95);
            this.listBox7.TabIndex = 0;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 420);
            this.Controls.Add(this.PnlOdul);
            this.Name = "Form9";
            this.Text = "Form9";
            this.PnlOdul.ResumeLayout(false);
            this.PnlOdul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlOdul;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBox7;
    }
}