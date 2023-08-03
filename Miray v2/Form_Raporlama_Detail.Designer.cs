namespace Miray_v2.Forms
{
    partial class Form_Raporlama_Detail
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            textBox1 = new System.Windows.Forms.TextBox();
            Satir_Sayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(760, 295);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(488, 23);
            textBox1.TabIndex = 2;
            // 
            // Satir_Sayisi
            // 
            Satir_Sayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Satir_Sayisi.Location = new System.Drawing.Point(506, 12);
            Satir_Sayisi.Name = "Satir_Sayisi";
            Satir_Sayisi.Size = new System.Drawing.Size(266, 23);
            Satir_Sayisi.TabIndex = 3;
            Satir_Sayisi.Text = "Toplam Veri Sayısı: ";
            Satir_Sayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Raporlama_Detail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 361);
            Controls.Add(Satir_Sayisi);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form_Raporlama_Detail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form_Raporlama_Detail";
            Load += Form_Raporlama_Detail_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Satir_Sayisi;
    }
}