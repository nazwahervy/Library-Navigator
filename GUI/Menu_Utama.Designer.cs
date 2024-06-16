namespace Library_Navigator
{
    partial class Menu_Utama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Utama));
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            logInToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            informasiToolStripMenuItem = new ToolStripMenuItem();
            pencarianBukuToolStripMenuItem = new ToolStripMenuItem();
            denahPerpustakaanToolStripMenuItem = new ToolStripMenuItem();
            kelolaPustakaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, informasiToolStripMenuItem, kelolaPustakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(843, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logInToolStripMenuItem, logOutToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // logInToolStripMenuItem
            // 
            logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            logInToolStripMenuItem.Size = new Size(224, 26);
            logInToolStripMenuItem.Text = "Log in";
            logInToolStripMenuItem.Click += logInToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(224, 26);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // informasiToolStripMenuItem
            // 
            informasiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pencarianBukuToolStripMenuItem, denahPerpustakaanToolStripMenuItem });
            informasiToolStripMenuItem.Name = "informasiToolStripMenuItem";
            informasiToolStripMenuItem.Size = new Size(85, 24);
            informasiToolStripMenuItem.Text = "Informasi";
            // 
            // pencarianBukuToolStripMenuItem
            // 
            pencarianBukuToolStripMenuItem.Name = "pencarianBukuToolStripMenuItem";
            pencarianBukuToolStripMenuItem.Size = new Size(226, 26);
            pencarianBukuToolStripMenuItem.Text = "Pencarian Buku";
            pencarianBukuToolStripMenuItem.Click += pencarianBukuToolStripMenuItem_Click;
            // 
            // denahPerpustakaanToolStripMenuItem
            // 
            denahPerpustakaanToolStripMenuItem.Name = "denahPerpustakaanToolStripMenuItem";
            denahPerpustakaanToolStripMenuItem.Size = new Size(226, 26);
            denahPerpustakaanToolStripMenuItem.Text = "Denah Perpustakaan";
            denahPerpustakaanToolStripMenuItem.Click += denahPerpustakaanToolStripMenuItem_Click;
            // 
            // kelolaPustakaToolStripMenuItem
            // 
            kelolaPustakaToolStripMenuItem.Name = "kelolaPustakaToolStripMenuItem";
            kelolaPustakaToolStripMenuItem.Size = new Size(119, 24);
            kelolaPustakaToolStripMenuItem.Text = "Kelola Pustaka";
            kelolaPustakaToolStripMenuItem.Click += kelolaPustakaToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 664);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(843, 33);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Top;
            toolStripStatusLabel1.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.ForeColor = SystemColors.InfoText;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(670, 27);
            toolStripStatusLabel1.Text = "Project Akhir Pemrograman Visual Kelompok 1 R-004 [Library Navigator]";
            // 
            // Menu_Utama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(843, 697);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Menu_Utama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library_Navigator";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem logInToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem informasiToolStripMenuItem;
        private ToolStripMenuItem kelolaPustakaToolStripMenuItem;
        private ToolStripMenuItem pencarianBukuToolStripMenuItem;
        private ToolStripMenuItem denahPerpustakaanToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
