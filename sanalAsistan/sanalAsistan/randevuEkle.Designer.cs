namespace sanalAsistan
{
    partial class randevuEkle
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
            this.textBaslik = new System.Windows.Forms.TextBox();
            this.textAciklama = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.KaydetRandevu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // textBaslik
            // 
            this.textBaslik.Location = new System.Drawing.Point(345, 107);
            this.textBaslik.Name = "textBaslik";
            this.textBaslik.Size = new System.Drawing.Size(200, 22);
            this.textBaslik.TabIndex = 3;
            // 
            // textAciklama
            // 
            this.textAciklama.Location = new System.Drawing.Point(345, 162);
            this.textAciklama.Multiline = true;
            this.textAciklama.Name = "textAciklama";
            this.textAciklama.Size = new System.Drawing.Size(200, 47);
            this.textAciklama.TabIndex = 4;
            this.textAciklama.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(345, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // KaydetRandevu
            // 
            this.KaydetRandevu.Location = new System.Drawing.Point(302, 306);
            this.KaydetRandevu.Name = "KaydetRandevu";
            this.KaydetRandevu.Size = new System.Drawing.Size(75, 23);
            this.KaydetRandevu.TabIndex = 6;
            this.KaydetRandevu.Text = "Kaydet";
            this.KaydetRandevu.UseVisualStyleBackColor = true;
            this.KaydetRandevu.Click += new System.EventHandler(this.KaydetRandevu_Click);
            // 
            // randevuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KaydetRandevu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textAciklama);
            this.Controls.Add(this.textBaslik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "randevuEkle";
            this.Text = "randevuEkle";
            this.Load += new System.EventHandler(this.randevuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBaslik;
        private System.Windows.Forms.TextBox textAciklama;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button KaydetRandevu;
    }
}