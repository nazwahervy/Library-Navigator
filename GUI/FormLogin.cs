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
    public partial class FormLogin : Form
    {
        private MySqlConnection conn;
        private Menu_Utama mainForm;

        public FormLogin(Menu_Utama callingForm)
        {
            mainForm = callingForm;
            InitializeComponent();
            string connectionString = "server=localhost;database=library_db;uid=root;pwd=;";
            conn = new MySqlConnection(connectionString);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login berhasil!");
                mainForm.loginProcess();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login gagal! Periksa username dan password Anda.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM admin_dt WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
