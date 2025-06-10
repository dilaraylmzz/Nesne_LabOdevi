namespace deney3
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
            this.lblSonuc1 = new System.Windows.Forms.Label();
            this.lblSonuc2 = new System.Windows.Forms.Label();
            this.lblSonuc3 = new System.Windows.Forms.Label();
            this.btnTestDortgenler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSonuc1
            // 
            this.lblSonuc1.AutoSize = true;
            this.lblSonuc1.Location = new System.Drawing.Point(110, 172);
            this.lblSonuc1.Name = "lblSonuc1";
            this.lblSonuc1.Size = new System.Drawing.Size(44, 16);
            this.lblSonuc1.TabIndex = 0;
            this.lblSonuc1.Text = "label1";
            // 
            // lblSonuc2
            // 
            this.lblSonuc2.AutoSize = true;
            this.lblSonuc2.Location = new System.Drawing.Point(237, 172);
            this.lblSonuc2.Name = "lblSonuc2";
            this.lblSonuc2.Size = new System.Drawing.Size(44, 16);
            this.lblSonuc2.TabIndex = 1;
            this.lblSonuc2.Text = "label2";
            // 
            // lblSonuc3
            // 
            this.lblSonuc3.AutoSize = true;
            this.lblSonuc3.Location = new System.Drawing.Point(362, 172);
            this.lblSonuc3.Name = "lblSonuc3";
            this.lblSonuc3.Size = new System.Drawing.Size(44, 16);
            this.lblSonuc3.TabIndex = 2;
            this.lblSonuc3.Text = "label3";
            // 
            // btnTestDortgenler
            // 
            this.btnTestDortgenler.Location = new System.Drawing.Point(133, 83);
            this.btnTestDortgenler.Name = "btnTestDortgenler";
            this.btnTestDortgenler.Size = new System.Drawing.Size(246, 49);
            this.btnTestDortgenler.TabIndex = 3;
            this.btnTestDortgenler.Text = "Dortgenleri Oluştur ve Test Et";
            this.btnTestDortgenler.UseVisualStyleBackColor = true;
            this.btnTestDortgenler.Click += new System.EventHandler(this.btnTestDortgenler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestDortgenler);
            this.Controls.Add(this.lblSonuc3);
            this.Controls.Add(this.lblSonuc2);
            this.Controls.Add(this.lblSonuc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc1;
        private System.Windows.Forms.Label lblSonuc2;
        private System.Windows.Forms.Label lblSonuc3;
        private System.Windows.Forms.Button btnTestDortgenler;
    }
}

