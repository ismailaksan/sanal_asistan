namespace sanalAsistan
{
    partial class anımsatıcıcListele
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
            this.dgvAnimsaticilar = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimsaticilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimsaticilar
            // 
            this.dgvAnimsaticilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimsaticilar.Location = new System.Drawing.Point(105, 12);
            this.dgvAnimsaticilar.Name = "dgvAnimsaticilar";
            this.dgvAnimsaticilar.RowHeadersWidth = 51;
            this.dgvAnimsaticilar.RowTemplate.Height = 24;
            this.dgvAnimsaticilar.Size = new System.Drawing.Size(592, 382);
            this.dgvAnimsaticilar.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(339, 415);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Seçili Anımsatıcıyı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // anımsatıcıcListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvAnimsaticilar);
            this.Name = "anımsatıcıcListele";
            this.Text = "Anımsatıcı Listele";
            this.Load += new System.EventHandler(this.anımsatıcıcListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimsaticilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimsaticilar;
        private System.Windows.Forms.Button btnSil;
    }
}