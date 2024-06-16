using System.Configuration;
using System.Windows.Forms;
using Library_Navigator.GUI;
using MySql.Data.MySqlClient;
using PencarianBuku;

namespace Library_Navigator
{
    public partial class Menu_Utama : Form
    {
        FormCariBuku? cariBuku;
        Kelola_Pustaka? kelola;
        FormLogin? flogin;
        Denah? denahh;
        MySqlConnection conn;

        public Menu_Utama()
        {
            InitializeComponent();
            string connStr = ConfigurationManager.ConnectionStrings["library_db"].ConnectionString;
            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MessageBox.Show("Koneksi ke database berhasil!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }

            kelolaPustakaToolStripMenuItem.Enabled = false;

        }

        private void informasiToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void denahh_FormClosed(object? sender, FormClosedEventArgs e)
        {
            denahh = null;
        }

        void flogin_FormClosed(object? sender, FormClosedEventArgs e)
        {
            flogin = null;
        }

        void kelola_FormClosed(object? sender, FormClosedEventArgs e)
        {
            kelola = null;
        }

        void cariBuku_FormClosed(object? sender, FormClosedEventArgs e)
        {
            cariBuku = null;
        }

        private void pencarianBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cariBuku == null)
            {
                cariBuku = new FormCariBuku(conn);
                cariBuku.MdiParent = this;
                cariBuku.FormClosed += new FormClosedEventHandler(cariBuku_FormClosed);
                cariBuku.Show();
            }
            else
            {
                cariBuku.Activate();
            }

        }

        private void logInToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (flogin == null)
            {
                flogin = new FormLogin(this);
                flogin.MdiParent = this;
                flogin.FormClosed += new FormClosedEventHandler(flogin_FormClosed);
                flogin.Show();
            }
            else
            {
                flogin.Activate();
            }
        }

        private void kelolaPustakaToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (kelola == null)
            {
                kelola = new Kelola_Pustaka(conn);
                kelola.MdiParent = this;
                kelola.FormClosed += new FormClosedEventHandler(kelola_FormClosed);
                kelola.Show();
            }
            else
            {
                kelola.Activate();
            }
        }

        private void denahPerpustakaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (denahh == null)
            {
                denahh = new Denah();
                denahh.MdiParent = this;
                denahh.FormClosed += new FormClosedEventHandler(denahh_FormClosed);
                denahh.Show();
            }
            else
            {
                denahh.Activate();
            }

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                logoutProcess();

            }
        }

        private void logoutProcess()
        {
            kelolaPustakaToolStripMenuItem.Enabled = false;
        }
        public void loginProcess()
        {
            kelolaPustakaToolStripMenuItem.Enabled = true;
        }
    }
}
