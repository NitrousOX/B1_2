namespace B1_2
{
    partial class Prijava
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Pas_lbl = new System.Windows.Forms.Label();
            this.Izlozba_lbl = new System.Windows.Forms.Label();
            this.Kategorija_lbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Upisi_btn = new System.Windows.Forms.Button();
            this.Brisanje_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izbor akcije";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Brisanje";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Unos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Pas_lbl
            // 
            this.Pas_lbl.AutoSize = true;
            this.Pas_lbl.Location = new System.Drawing.Point(20, 135);
            this.Pas_lbl.Name = "Pas_lbl";
            this.Pas_lbl.Size = new System.Drawing.Size(25, 13);
            this.Pas_lbl.TabIndex = 1;
            this.Pas_lbl.Text = "Pas";
            // 
            // Izlozba_lbl
            // 
            this.Izlozba_lbl.AutoSize = true;
            this.Izlozba_lbl.Location = new System.Drawing.Point(20, 205);
            this.Izlozba_lbl.Name = "Izlozba_lbl";
            this.Izlozba_lbl.Size = new System.Drawing.Size(40, 13);
            this.Izlozba_lbl.TabIndex = 2;
            this.Izlozba_lbl.Text = "Izlozba";
            // 
            // Kategorija_lbl
            // 
            this.Kategorija_lbl.AutoSize = true;
            this.Kategorija_lbl.Location = new System.Drawing.Point(20, 260);
            this.Kategorija_lbl.Name = "Kategorija_lbl";
            this.Kategorija_lbl.Size = new System.Drawing.Size(54, 13);
            this.Kategorija_lbl.TabIndex = 3;
            this.Kategorija_lbl.Text = "Kategorija";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(92, 205);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(92, 260);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // Upisi_btn
            // 
            this.Upisi_btn.Location = new System.Drawing.Point(23, 329);
            this.Upisi_btn.Name = "Upisi_btn";
            this.Upisi_btn.Size = new System.Drawing.Size(75, 23);
            this.Upisi_btn.TabIndex = 7;
            this.Upisi_btn.Text = "Upisi";
            this.Upisi_btn.UseVisualStyleBackColor = true;
            this.Upisi_btn.Click += new System.EventHandler(this.Upisi_btn_Click);
            // 
            // Brisanje_btn
            // 
            this.Brisanje_btn.Location = new System.Drawing.Point(138, 329);
            this.Brisanje_btn.Name = "Brisanje_btn";
            this.Brisanje_btn.Size = new System.Drawing.Size(75, 23);
            this.Brisanje_btn.TabIndex = 8;
            this.Brisanje_btn.Text = "Brisi";
            this.Brisanje_btn.UseVisualStyleBackColor = true;
            this.Brisanje_btn.Click += new System.EventHandler(this.Brisanje_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Izadji";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 442);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Brisanje_btn);
            this.Controls.Add(this.Upisi_btn);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Kategorija_lbl);
            this.Controls.Add(this.Izlozba_lbl);
            this.Controls.Add(this.Pas_lbl);
            this.Controls.Add(this.groupBox1);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label Pas_lbl;
        private System.Windows.Forms.Label Izlozba_lbl;
        private System.Windows.Forms.Label Kategorija_lbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button Upisi_btn;
        private System.Windows.Forms.Button Brisanje_btn;
        private System.Windows.Forms.Button button3;
    }
}