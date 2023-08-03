
namespace Miray_v2.Forms
{
    partial class Formmusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formmusteri));
            label1 = new System.Windows.Forms.Label();
            ara = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            numara = new System.Windows.Forms.Label();
            ad = new System.Windows.Forms.Label();
            plaka = new System.Windows.Forms.Label();
            mid = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(14, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Listesinde Ara:";
            // 
            // ara
            // 
            ara.Location = new System.Drawing.Point(162, 12);
            ara.Name = "ara";
            ara.Size = new System.Drawing.Size(188, 23);
            ara.TabIndex = 1;
            ara.TextChanged += ara_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(776, 376);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Image = Properties.Resources.add;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(506, 11);
            button1.Name = "button1";
            button1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            button1.Size = new System.Drawing.Size(90, 30);
            button1.TabIndex = 3;
            button1.Text = "     Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button2.BackColor = System.Drawing.Color.FromArgb(254, 202, 87);
            button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Image = Properties.Resources.editing;
            button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.Location = new System.Drawing.Point(602, 11);
            button2.Name = "button2";
            button2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            button2.Size = new System.Drawing.Size(90, 30);
            button2.TabIndex = 4;
            button2.Text = "    Düzenle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button3.BackColor = System.Drawing.Color.FromArgb(255, 71, 87);
            button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.White;
            button3.Image = Properties.Resources.remove;
            button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.Location = new System.Drawing.Point(698, 11);
            button3.Name = "button3";
            button3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            button3.Size = new System.Drawing.Size(90, 30);
            button3.TabIndex = 5;
            button3.Text = "  Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // numara
            // 
            numara.AutoSize = true;
            numara.Location = new System.Drawing.Point(506, 41);
            numara.Name = "numara";
            numara.Size = new System.Drawing.Size(0, 15);
            numara.TabIndex = 8;
            numara.TextChanged += numara_TextChanged;
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Location = new System.Drawing.Point(550, 41);
            ad.Name = "ad";
            ad.Size = new System.Drawing.Size(0, 15);
            ad.TabIndex = 9;
            // 
            // plaka
            // 
            plaka.AutoSize = true;
            plaka.Location = new System.Drawing.Point(594, 41);
            plaka.Name = "plaka";
            plaka.Size = new System.Drawing.Size(0, 15);
            plaka.TabIndex = 10;
            // 
            // mid
            // 
            mid.AutoSize = true;
            mid.Location = new System.Drawing.Point(632, 44);
            mid.Name = "mid";
            mid.Size = new System.Drawing.Size(0, 15);
            mid.TabIndex = 11;
            // 
            // button4
            // 
            button4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button4.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.ForeColor = System.Drawing.Color.White;
            button4.Image = Properties.Resources.file_excel;
            button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button4.Location = new System.Drawing.Point(374, 11);
            button4.Name = "button4";
            button4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            button4.Size = new System.Drawing.Size(126, 30);
            button4.TabIndex = 12;
            button4.Text = "  Excel'den Aktar";
            button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Formmusteri
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button4);
            Controls.Add(mid);
            Controls.Add(plaka);
            Controls.Add(ad);
            Controls.Add(numara);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(ara);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Formmusteri";
            Text = "Müşteri Listesi";
            Load += Formmusteri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label numara;
        public System.Windows.Forms.Label ad;
        public System.Windows.Forms.Label plaka;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label mid;
        private System.Windows.Forms.Button button4;
    }
}