using System.Data;
using MySql.Data.MySqlClient;

namespace PencarianBuku
{
    public partial class FormCariBuku : Form
    {
        MySqlConnection conn;
        public FormCariBuku(MySqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
            this.Load += new System.EventHandler(this.FormCariBuku_Load);
        }

        private void FormCariBuku_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT judul_buku AS 'Judul Buku', penulis AS 'Penulis', kategori_buku AS 'Kategori Buku', lokasi_rak AS 'Lokasi Rak', stok_buku AS 'Stok Buku' FROM buku_dt";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AlternatingRowsDefaultCellStyle = dataGridView1.DefaultCellStyle;
                dataGridView1.Columns["Judul Buku"].Width = 316;
                dataGridView1.Columns["Penulis"].Width = 200;
                dataGridView1.Columns["Kategori Buku"].Width = 180;
                dataGridView1.Columns["Lokasi Rak"].Width = 150;
                dataGridView1.Columns["Stok Buku"].Width = 150;

                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bookman Old Style", 11, FontStyle.Bold);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData(textBox1.Text);
        }

        private void LoadData(string searchKeyword)
        {
            try
            {
                string query = "SELECT judul_buku AS 'Judul Buku', penulis AS 'Penulis', kategori_buku AS 'Kategori Buku', lokasi_rak AS 'Lokasi Rak', stok_buku AS 'Stok Buku' FROM buku_dt WHERE judul_buku LIKE @searchKeyword or kategori_buku LIKE @searchKeyword or penulis LIKE @searchKeyword";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchKeyword", "%" + searchKeyword + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Judul Buku"].Width = 316;
                dataGridView1.Columns["Penulis"].Width = 200;
                dataGridView1.Columns["Kategori Buku"].Width = 180;
                dataGridView1.Columns["Lokasi Rak"].Width = 150;
                dataGridView1.Columns["Stok Buku"].Width = 150;

                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bookman Old Style", 11, FontStyle.Bold);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
