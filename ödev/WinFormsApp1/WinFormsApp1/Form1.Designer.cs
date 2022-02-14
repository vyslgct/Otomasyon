namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnYönetici = new System.Windows.Forms.Button();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Seçenekleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMusteri
            // 
            this.btnMusteri.Location = new System.Drawing.Point(12, 73);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(179, 33);
            this.btnMusteri.TabIndex = 1;
            this.btnMusteri.Text = "Müşteri Girişi";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnYönetici
            // 
            this.btnYönetici.Location = new System.Drawing.Point(219, 73);
            this.btnYönetici.Name = "btnYönetici";
            this.btnYönetici.Size = new System.Drawing.Size(179, 33);
            this.btnYönetici.TabIndex = 2;
            this.btnYönetici.Text = "Yönetici Girişi";
            this.btnYönetici.UseVisualStyleBackColor = true;
            this.btnYönetici.Click += new System.EventHandler(this.btnYönetici_Click);
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(12, 140);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(386, 33);
            this.btnKayıt.TabIndex = 3;
            this.btnKayıt.Text = "Kayıt ol";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(12, 192);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(386, 33);
            this.btnCıkıs.TabIndex = 4;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 255);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.btnYönetici);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnMusteri;
        private Button btnYönetici;
        private Button btnKayıt;
        private Button btnCıkıs;
    }
}