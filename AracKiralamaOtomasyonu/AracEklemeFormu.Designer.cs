namespace AracKiralamaOtomasyonu
{
    partial class AracEklemeFormu
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
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            txtMarka = new Label();
            label2 = new Label();
            txtModel = new TextBox();
            label3 = new Label();
            txtYakitTipi = new TextBox();
            label1 = new Label();
            txtUretimTarihi = new TextBox();
            label4 = new Label();
            txtGunlukUcret = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            cmbAracDurumu = new ComboBox();
            txtMarka1 = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(321, 19);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(398, 393);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mevcut Araçlar";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(4, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(390, 363);
            listBox1.TabIndex = 0;
            // 
            // txtMarka
            // 
            txtMarka.AutoSize = true;
            txtMarka.Location = new Point(7, 44);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(66, 21);
            txtMarka.TabIndex = 0;
            txtMarka.Text = "Marka :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 90);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 2;
            label2.Text = "Model :";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(157, 82);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 29);
            txtModel.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 140);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 4;
            label3.Text = "Yakıt Tipi :";
            // 
            // txtYakitTipi
            // 
            txtYakitTipi.Location = new Point(157, 132);
            txtYakitTipi.Name = "txtYakitTipi";
            txtYakitTipi.Size = new Size(100, 29);
            txtYakitTipi.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 192);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 6;
            label1.Text = "Üretim Tarihi :";
            // 
            // txtUretimTarihi
            // 
            txtUretimTarihi.Location = new Point(157, 184);
            txtUretimTarihi.Name = "txtUretimTarihi";
            txtUretimTarihi.Size = new Size(100, 29);
            txtUretimTarihi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 243);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 8;
            label4.Text = "Günlük Ücreti :";
            // 
            // txtGunlukUcret
            // 
            txtGunlukUcret.Location = new Point(157, 235);
            txtGunlukUcret.Name = "txtGunlukUcret";
            txtGunlukUcret.Size = new Size(100, 29);
            txtGunlukUcret.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 292);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 10;
            label5.Text = "Aracın Durumu :";
            // 
            // button1
            // 
            button1.Location = new Point(7, 336);
            button1.Name = "button1";
            button1.Size = new Size(89, 34);
            button1.TabIndex = 12;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 336);
            button2.Name = "button2";
            button2.Size = new Size(89, 34);
            button2.TabIndex = 13;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(197, 336);
            button3.Name = "button3";
            button3.Size = new Size(89, 34);
            button3.TabIndex = 14;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbAracDurumu);
            groupBox1.Controls.Add(txtMarka1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtGunlukUcret);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUretimTarihi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtYakitTipi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMarka);
            groupBox1.Location = new Point(17, 17);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(296, 393);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Araç Ekleme Kısmı :";
            // 
            // cmbAracDurumu
            // 
            cmbAracDurumu.FormattingEnabled = true;
            cmbAracDurumu.Location = new Point(157, 284);
            cmbAracDurumu.Name = "cmbAracDurumu";
            cmbAracDurumu.Size = new Size(100, 29);
            cmbAracDurumu.TabIndex = 16;
            // 
            // txtMarka1
            // 
            txtMarka1.Location = new Point(157, 36);
            txtMarka1.Name = "txtMarka1";
            txtMarka1.Size = new Size(100, 29);
            txtMarka1.TabIndex = 15;
            // 
            // AracEklemeFormu
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(728, 420);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AracEklemeFormu";
            Text = "AracEklemeFormu";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private ListBox listBox1;
        private Label txtMarka;
        private Label label2;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtYakitTipi;
        private Label label1;
        private TextBox txtUretimTarihi;
        private Label label4;
        private TextBox txtGunlukUcret;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private TextBox txtMarka1;
        private ComboBox cmbAracDurumu;
    }
}