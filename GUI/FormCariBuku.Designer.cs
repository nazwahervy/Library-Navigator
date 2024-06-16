
namespace PencarianBuku
{
    partial class FormCariBuku
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(464, 19);
            label1.Name = "label1";
            label1.Size = new Size(192, 40);
            label1.TabIndex = 0;
            label1.Text = "Cari Buku";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 99);
            label2.Name = "label2";
            label2.Size = new Size(620, 21);
            label2.TabIndex = 1;
            label2.Text = "Masukkan judul, nama penulis atau kategori buku yang ingin anda cari:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(54, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(620, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaption;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlText;
            dataGridView1.Location = new Point(54, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1050, 403);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 631);
            label3.Name = "label3";
            label3.Size = new Size(732, 23);
            label3.TabIndex = 6;
            label3.Text = "p.s. Anda dapat Melihat Lokasi Rak pada Denah Perpustakaan di Menu Informasi.";
            // 
            // FormCariBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1163, 690);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormCariBuku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Cari_Buku";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label3;
    }
}
