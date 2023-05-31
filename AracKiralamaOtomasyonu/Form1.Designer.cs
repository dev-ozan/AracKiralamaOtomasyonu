namespace AracKiralamaOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtSoyad = new TextBox();
            label6 = new Label();
            txtMail = new TextBox();
            label3 = new Label();
            btnUyeOl = new Button();
            txtSifre = new TextBox();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtGirisSoyad = new TextBox();
            btnGirisYap = new Button();
            btnGirisSifre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtGirisKullaniciAdi = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnUyeOl);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 322);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye Ol";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(141, 86);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 29);
            txtSoyad.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 94);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 7;
            label6.Text = "Soyad :";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(141, 181);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 29);
            txtMail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 189);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 5;
            label3.Text = "Mail :";
            // 
            // btnUyeOl
            // 
            btnUyeOl.Location = new Point(21, 253);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(220, 36);
            btnUyeOl.TabIndex = 4;
            btnUyeOl.Text = "Üye Ol";
            btnUyeOl.UseVisualStyleBackColor = true;
            btnUyeOl.Click += button1_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(141, 132);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 29);
            txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 140);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(141, 44);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 29);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 52);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtGirisSoyad);
            groupBox2.Controls.Add(btnGirisYap);
            groupBox2.Controls.Add(btnGirisSifre);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtGirisKullaniciAdi);
            groupBox2.Location = new Point(349, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 322);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giriş Yap";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 94);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 11;
            label7.Text = "Soyad :";
            // 
            // txtGirisSoyad
            // 
            txtGirisSoyad.Location = new Point(144, 86);
            txtGirisSoyad.Name = "txtGirisSoyad";
            txtGirisSoyad.Size = new Size(100, 29);
            txtGirisSoyad.TabIndex = 12;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(24, 192);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(220, 36);
            btnGirisYap.TabIndex = 7;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnGirisSifre
            // 
            btnGirisSifre.Location = new Point(144, 132);
            btnGirisSifre.Name = "btnGirisSifre";
            btnGirisSifre.Size = new Size(100, 29);
            btnGirisSifre.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 52);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 7;
            label5.Text = "Ad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 140);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 9;
            label4.Text = "Şifre :";
            // 
            // txtGirisKullaniciAdi
            // 
            txtGirisKullaniciAdi.Location = new Point(144, 44);
            txtGirisKullaniciAdi.Name = "txtGirisKullaniciAdi";
            txtGirisKullaniciAdi.Size = new Size(100, 29);
            txtGirisKullaniciAdi.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(639, 364);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMail;
        private Label label3;
        private Button btnUyeOl;
        private TextBox txtSifre;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnGirisYap;
        private TextBox btnGirisSifre;
        private Label label5;
        private Label label4;
        private TextBox txtGirisKullaniciAdi;
        private TextBox txtSoyad;
        private Label label6;
        private Label label7;
        private TextBox txtGirisSoyad;
    }
}