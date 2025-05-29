namespace sanalAsistan
{
    partial class GirisVeKayitEkrani
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textparola = new System.Windows.Forms.TextBox();
            this.textadsoyad = new System.Windows.Forms.TextBox();
            this.Giris = new System.Windows.Forms.Button();
            this.Kayit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(231, 112);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(138, 22);
            this.textemail.TabIndex = 3;
            // 
            // textparola
            // 
            this.textparola.Location = new System.Drawing.Point(231, 167);
            this.textparola.Name = "textparola";
            this.textparola.Size = new System.Drawing.Size(138, 22);
            this.textparola.TabIndex = 5;
            this.textparola.TextChanged += new System.EventHandler(this.parola_TextChanged);
            // 
            // textadsoyad
            // 
            this.textadsoyad.Location = new System.Drawing.Point(231, 224);
            this.textadsoyad.Name = "textadsoyad";
            this.textadsoyad.Size = new System.Drawing.Size(138, 22);
            this.textadsoyad.TabIndex = 7;
            // 
            // Giris
            // 
            this.Giris.Location = new System.Drawing.Point(541, 135);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(75, 23);
            this.Giris.TabIndex = 8;
            this.Giris.Text = "Giriş";
            this.Giris.UseVisualStyleBackColor = true;
            this.Giris.Click += new System.EventHandler(this.Giris_Click);
            // 
            // Kayit
            // 
            this.Kayit.Location = new System.Drawing.Point(541, 197);
            this.Kayit.Name = "Kayit";
            this.Kayit.Size = new System.Drawing.Size(75, 23);
            this.Kayit.TabIndex = 9;
            this.Kayit.Text = "Kayıt";
            this.Kayit.UseVisualStyleBackColor = true;
            this.Kayit.Click += new System.EventHandler(this.Kayit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(639, 72);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sanal Asistanınıza Hoş Geldiniz \r\nEğer Hesap Oluşturmadıysanız Lüten Kayıt\'a bası" +
    "n.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GirisVeKayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Kayit);
            this.Controls.Add(this.Giris);
            this.Controls.Add(this.textadsoyad);
            this.Controls.Add(this.textparola);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisVeKayitEkrani";
            this.Text = "Giris ve Kayıt Ekrani";
            this.Load += new System.EventHandler(this.GirisVeKayitEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textparola;
        private System.Windows.Forms.TextBox textadsoyad;
        private System.Windows.Forms.Button Giris;
        private System.Windows.Forms.Button Kayit;
        private System.Windows.Forms.Label label4;
    }
}