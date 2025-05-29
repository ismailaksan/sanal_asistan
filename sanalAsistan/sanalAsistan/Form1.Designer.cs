namespace sanalAsistan
{
    partial class listelerandevu
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
            this.components = new System.ComponentModel.Container();
            this.randevuButton = new System.Windows.Forms.Button();
            this.randevuListele = new System.Windows.Forms.Button();
            this.notDefterineGit = new System.Windows.Forms.Button();
            this.anımsatıcıListele = new System.Windows.Forms.Button();
            this.anımsaticiEkle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.labelSaat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randevuButton
            // 
            this.randevuButton.Location = new System.Drawing.Point(69, 229);
            this.randevuButton.Name = "randevuButton";
            this.randevuButton.Size = new System.Drawing.Size(130, 23);
            this.randevuButton.TabIndex = 1;
            this.randevuButton.Text = "Randevu Ekle";
            this.randevuButton.UseVisualStyleBackColor = true;
            this.randevuButton.Click += new System.EventHandler(this.randevuButton_Click);
            // 
            // randevuListele
            // 
            this.randevuListele.Location = new System.Drawing.Point(12, 275);
            this.randevuListele.Name = "randevuListele";
            this.randevuListele.Size = new System.Drawing.Size(241, 23);
            this.randevuListele.TabIndex = 5;
            this.randevuListele.Text = "Randevularımı Görüntüle";
            this.randevuListele.UseVisualStyleBackColor = true;
            this.randevuListele.Click += new System.EventHandler(this.randevuListele_Click);
            // 
            // notDefterineGit
            // 
            this.notDefterineGit.Location = new System.Drawing.Point(315, 275);
            this.notDefterineGit.Name = "notDefterineGit";
            this.notDefterineGit.Size = new System.Drawing.Size(179, 23);
            this.notDefterineGit.TabIndex = 6;
            this.notDefterineGit.Text = "Not Defterim";
            this.notDefterineGit.UseVisualStyleBackColor = true;
            this.notDefterineGit.Click += new System.EventHandler(this.notDefterineGit_Click);
            // 
            // anımsatıcıListele
            // 
            this.anımsatıcıListele.Location = new System.Drawing.Point(547, 275);
            this.anımsatıcıListele.Name = "anımsatıcıListele";
            this.anımsatıcıListele.Size = new System.Drawing.Size(241, 26);
            this.anımsatıcıListele.TabIndex = 7;
            this.anımsatıcıListele.Text = "Anımsatıcılarım";
            this.anımsatıcıListele.UseVisualStyleBackColor = true;
            this.anımsatıcıListele.Click += new System.EventHandler(this.anımsatıcıListele_Click);
            // 
            // anımsaticiEkle
            // 
            this.anımsaticiEkle.Location = new System.Drawing.Point(608, 229);
            this.anımsaticiEkle.Name = "anımsaticiEkle";
            this.anımsaticiEkle.Size = new System.Drawing.Size(130, 23);
            this.anımsaticiEkle.TabIndex = 8;
            this.anımsaticiEkle.Text = "Anımsatıcı Ekle";
            this.anımsaticiEkle.UseVisualStyleBackColor = true;
            this.anımsaticiEkle.Click += new System.EventHandler(this.anımsaticiEkle_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 76);
            this.label1.TabIndex = 9;
            this.label1.Text = "Merhaba Kullanıcı! Sanal Asistanına hoş geldin. \r\nBugün ne yapmak istersin?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timerSaat
            // 
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSaat.Location = new System.Drawing.Point(385, 151);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(52, 26);
            this.labelSaat.TabIndex = 10;
            this.labelSaat.Text = "Saat";
            this.labelSaat.Click += new System.EventHandler(this.labelSaat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(273, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Saat Şu An:";
            // 
            // listelerandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSaat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anımsaticiEkle);
            this.Controls.Add(this.anımsatıcıListele);
            this.Controls.Add(this.notDefterineGit);
            this.Controls.Add(this.randevuListele);
            this.Controls.Add(this.randevuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listelerandevu";
            this.Text = "Sanal Asistan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button randevuButton;
        private System.Windows.Forms.Button randevuListele;
        private System.Windows.Forms.Button notDefterineGit;
        private System.Windows.Forms.Button anımsatıcıListele;
        private System.Windows.Forms.Button anımsaticiEkle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Label label2;
    }
}

