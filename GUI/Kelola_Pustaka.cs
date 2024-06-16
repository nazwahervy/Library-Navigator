using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Navigator.GUI
{
    public partial class Kelola_Pustaka : Form
    {
        MySqlConnection conn;
        public Kelola_Pustaka(MySqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
            this.Load += new System.EventHandler(this.KelolaPustaka_Load);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            textBox6.ReadOnly = true;
            button1.Click += new EventHandler(this.ButtonCreate_Click);
            button2.Click += new EventHandler(this.ButtonUpdate_Click);
            button3.Click += new EventHandler(this.ButtonDelete_Click);
            button4.Click += new EventHandler(this.ButtonSave_Click);
        }

        private void KelolaPustaka_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT nomor_buku AS 'Nomor Buku', judul_buku AS 'Judul Buku', penulis AS 'Penulis', kategori_buku AS 'Kategori Buku', lokasi_rak AS 'Lokasi Rak', stok_buku AS 'Stok Buku' FROM buku_dt";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AlternatingRowsDefaultCellStyle = dataGridView1.DefaultCellStyle;

                dataGridView1.Columns["Nomor Buku"].Width = 170;
                dataGridView1.Columns["Judul Buku"].Width = 311;
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

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox6.Text = row.Cells["Nomor Buku"].Value.ToString();
                textBox1.Text = row.Cells["Judul Buku"].Value.ToString();
                textBox2.Text = row.Cells["Penulis"].Value.ToString();
                comboBox1.Text = row.Cells["Kategori Buku"].Value.ToString();
                textBox4.Text = row.Cells["Lokasi Rak"].Value.ToString();
                textBox5.Text = row.Cells["Stok Buku"].Value.ToString();
            }
        }

        private void ButtonCreate_Click(object? sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ButtonUpdate_Click(object? sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "UPDATE buku_dt SET judul_buku = @Judul, penulis = @Penulis, kategori_buku = @Kategori, lokasi_rak = @Lokasi, stok_buku = @Stok WHERE nomor_buku = @Nomor";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nomor", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Judul", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Penulis", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Kategori", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Lokasi", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Stok", textBox5.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show("Data updated successfully.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); 
            }
        }

        private void ButtonDelete_Click(object? sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string query = "DELETE FROM buku_dt WHERE nomor_buku = @Nomor";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nomor", textBox6.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show("Data deleted successfully.");
                ClearTextBoxes();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string query = "INSERT INTO buku_dt (judul_buku, penulis, kategori_buku, lokasi_rak, stok_buku) VALUES (@Judul, @Penulis, @Kategori, @Lokasi, @Stok)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Judul", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Penulis", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Kategori", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Lokasi", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Stok", textBox5.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show("Data saved successfully.");
                textBox6.ReadOnly = true;
                ClearTextBoxes();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void ClearTextBoxes()
        {
            textBox6.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Kelola_Pustaka_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
