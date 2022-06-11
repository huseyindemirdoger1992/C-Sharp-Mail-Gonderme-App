namespace C_Sharp_Mail_Gonderme_App
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txticerik = new System.Windows.Forms.TextBox();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGondericiMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGondericiPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alıcı";
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(72, 157);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(409, 22);
            this.txtAlici.TabIndex = 1;
            this.txtAlici.Text = "huseyindemirdoger1992@gmail.com";
            this.txtAlici.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başlık";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(72, 185);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(409, 22);
            this.txtBaslik.TabIndex = 1;
            this.txtBaslik.Text = "Başlıktır Başlık";
            this.txtBaslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "İçerik";
            // 
            // txticerik
            // 
            this.txticerik.Location = new System.Drawing.Point(72, 213);
            this.txticerik.Multiline = true;
            this.txticerik.Name = "txticerik";
            this.txticerik.Size = new System.Drawing.Size(409, 84);
            this.txticerik.TabIndex = 1;
            this.txticerik.Text = "11.06.2022 Tarihli İçeriktir.";
            this.txticerik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(106, 304);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(375, 22);
            this.txtDosya.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ek";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(466, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Mail Gönder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gönderici Mail";
            // 
            // txtGondericiMail
            // 
            this.txtGondericiMail.Location = new System.Drawing.Point(111, 34);
            this.txtGondericiMail.Name = "txtGondericiMail";
            this.txtGondericiMail.Size = new System.Drawing.Size(370, 22);
            this.txtGondericiMail.TabIndex = 7;
            this.txtGondericiMail.Text = "huseyindemirdoger1992@hotmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gönderici Pass";
            // 
            // txtGondericiPass
            // 
            this.txtGondericiPass.Location = new System.Drawing.Point(111, 62);
            this.txtGondericiPass.Name = "txtGondericiPass";
            this.txtGondericiPass.PasswordChar = '*';
            this.txtGondericiPass.Size = new System.Drawing.Size(370, 22);
            this.txtGondericiPass.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gönderici Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(146, 6);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(335, 22);
            this.txtAdSoyad.TabIndex = 7;
            this.txtAdSoyad.Text = "Hüseyin Demirdöğer";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Microsoft",
            "Google"});
            this.comboBox1.Location = new System.Drawing.Point(111, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Microsoft";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sunucu Seçin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 370);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtGondericiPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtGondericiMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDosya);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txticerik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlici);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txticerik;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGondericiMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGondericiPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}

