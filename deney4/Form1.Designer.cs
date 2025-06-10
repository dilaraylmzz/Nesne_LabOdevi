namespace deney4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGenislik = new System.Windows.Forms.Label();
            this.labelYukseklik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSekil = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGenislik
            // 
            this.labelGenislik.AutoSize = true;
            this.labelGenislik.Location = new System.Drawing.Point(12, 21);
            this.labelGenislik.Name = "labelGenislik";
            this.labelGenislik.Size = new System.Drawing.Size(58, 16);
            this.labelGenislik.TabIndex = 0;
            this.labelGenislik.Text = "Genişlik:";
            this.labelGenislik.Click += new System.EventHandler(this.labelGenislik_Click);
            // 
            // labelYukseklik
            // 
            this.labelYukseklik.AutoSize = true;
            this.labelYukseklik.Location = new System.Drawing.Point(12, 64);
            this.labelYukseklik.Name = "labelYukseklik";
            this.labelYukseklik.Size = new System.Drawing.Size(68, 16);
            this.labelYukseklik.TabIndex = 1;
            this.labelYukseklik.Text = "Yükseklik:";
            this.labelYukseklik.Click += new System.EventHandler(this.labelYukseklik_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelSekil
            // 
            this.labelSekil.AutoSize = true;
            this.labelSekil.Location = new System.Drawing.Point(12, 107);
            this.labelSekil.Name = "labelSekil";
            this.labelSekil.Size = new System.Drawing.Size(67, 16);
            this.labelSekil.TabIndex = 4;
            this.labelSekil.Text = "Şekil Seç:";
            this.labelSekil.Click += new System.EventHandler(this.labelSekil_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Location = new System.Drawing.Point(25, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(57, 211);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(48, 16);
            this.labelSonuc.TabIndex = 7;
            this.labelSonuc.Text = "Sonuç:";
            this.labelSonuc.Click += new System.EventHandler(this.labelSonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(348, 265);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSekil);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelYukseklik);
            this.Controls.Add(this.labelGenislik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenislik;
        private System.Windows.Forms.Label labelYukseklik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelSekil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSonuc;
    }
}

