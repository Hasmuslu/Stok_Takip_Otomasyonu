namespace Stok_takip_projesi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.texttel = new System.Windows.Forms.TextBox();
            this.textadsoyad = new System.Windows.Forms.TextBox();
            this.texttc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.texttoplamfiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textmiktar = new System.Windows.Forms.TextBox();
            this.textsatisfiyat = new System.Windows.Forms.TextBox();
            this.textbarkod = new System.Windows.Forms.TextBox();
            this.textürünadi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblgeneltoplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.texttel);
            this.groupBox1.Controls.Add(this.textadsoyad);
            this.groupBox1.Controls.Add(this.texttc);
            this.groupBox1.Location = new System.Drawing.Point(11, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // texttel
            // 
            this.texttel.Location = new System.Drawing.Point(94, 91);
            this.texttel.Name = "texttel";
            this.texttel.Size = new System.Drawing.Size(100, 20);
            this.texttel.TabIndex = 2;
            // 
            // textadsoyad
            // 
            this.textadsoyad.Location = new System.Drawing.Point(93, 65);
            this.textadsoyad.Name = "textadsoyad";
            this.textadsoyad.Size = new System.Drawing.Size(100, 20);
            this.textadsoyad.TabIndex = 1;
            // 
            // texttc
            // 
            this.texttc.Location = new System.Drawing.Point(94, 39);
            this.texttc.Name = "texttc";
            this.texttc.Size = new System.Drawing.Size(100, 20);
            this.texttc.TabIndex = 0;
            this.texttc.TextChanged += new System.EventHandler(this.texttc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.texttoplamfiyat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textmiktar);
            this.groupBox2.Controls.Add(this.textsatisfiyat);
            this.groupBox2.Controls.Add(this.textbarkod);
            this.groupBox2.Controls.Add(this.textürünadi);
            this.groupBox2.Location = new System.Drawing.Point(11, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 192);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Toplam Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Miktar";
            // 
            // texttoplamfiyat
            // 
            this.texttoplamfiyat.Location = new System.Drawing.Point(95, 123);
            this.texttoplamfiyat.Name = "texttoplamfiyat";
            this.texttoplamfiyat.Size = new System.Drawing.Size(100, 20);
            this.texttoplamfiyat.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "BankodNO";
            // 
            // textmiktar
            // 
            this.textmiktar.Location = new System.Drawing.Point(94, 71);
            this.textmiktar.Name = "textmiktar";
            this.textmiktar.Size = new System.Drawing.Size(100, 20);
            this.textmiktar.TabIndex = 2;
            this.textmiktar.Text = "1";
            this.textmiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textmiktar.TextChanged += new System.EventHandler(this.textmiktar_TextChanged);
            // 
            // textsatisfiyat
            // 
            this.textsatisfiyat.Location = new System.Drawing.Point(94, 97);
            this.textsatisfiyat.Name = "textsatisfiyat";
            this.textsatisfiyat.Size = new System.Drawing.Size(100, 20);
            this.textsatisfiyat.TabIndex = 1;
            this.textsatisfiyat.TextChanged += new System.EventHandler(this.textsatisfiyat_TextChanged);
            // 
            // textbarkod
            // 
            this.textbarkod.Location = new System.Drawing.Point(94, 19);
            this.textbarkod.Name = "textbarkod";
            this.textbarkod.Size = new System.Drawing.Size(100, 20);
            this.textbarkod.TabIndex = 0;
            this.textbarkod.TextChanged += new System.EventHandler(this.textbarkod_TextChanged);
            // 
            // textürünadi
            // 
            this.textürünadi.Location = new System.Drawing.Point(93, 45);
            this.textürünadi.Name = "textürünadi";
            this.textürünadi.Size = new System.Drawing.Size(100, 20);
            this.textürünadi.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 392);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(876, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(876, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Satıl İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(770, 583);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Satış Yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 582);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblgeneltoplam
            // 
            this.lblgeneltoplam.AutoSize = true;
            this.lblgeneltoplam.Location = new System.Drawing.Point(487, 592);
            this.lblgeneltoplam.Name = "lblgeneltoplam";
            this.lblgeneltoplam.Size = new System.Drawing.Size(73, 13);
            this.lblgeneltoplam.TabIndex = 4;
            this.lblgeneltoplam.Text = "Genel Toplam";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 100);
            this.panel1.TabIndex = 6;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(676, 30);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(92, 45);
            this.button11.TabIndex = 5;
            this.button11.Text = "Marka";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(566, 30);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(92, 45);
            this.button10.TabIndex = 5;
            this.button10.Text = "Kategori";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(457, 30);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 45);
            this.button9.TabIndex = 4;
            this.button9.Text = "Satış Listeleme";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(352, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 45);
            this.button8.TabIndex = 3;
            this.button8.Text = "Ürün Listeleme";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(243, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 45);
            this.button7.TabIndex = 2;
            this.button7.Text = "Ürün Ekleme";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(135, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 45);
            this.button6.TabIndex = 1;
            this.button6.Text = "Müşteri Listeleme";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 45);
            this.button5.TabIndex = 0;
            this.button5.Text = "Müşteri Ekleme";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblgeneltoplam);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texttel;
        private System.Windows.Forms.TextBox textadsoyad;
        private System.Windows.Forms.TextBox texttc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texttoplamfiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textmiktar;
        private System.Windows.Forms.TextBox textsatisfiyat;
        private System.Windows.Forms.TextBox textbarkod;
        private System.Windows.Forms.TextBox textürünadi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblgeneltoplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
    }
}

