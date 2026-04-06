using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinFormsApp1
{

    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\emrea\\Documents\\deneme.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string checkUsername = "SELECT * FROM loginData WHERE username ='"
                        + textBox1.Text.Trim() + "'" + "AND password_u ='" + textBox2.Text.Trim() + "'";

                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (textBox1.Text == "")
                        {
                            errorProvider1.SetError(textBox1, "Kullanıcı Adı Boş Bırakılamaz!");
                        }
                        else if (textBox2.Text == "")
                        {
                            errorProvider2.SetError(textBox2, "Şifre Boş Bırakılamaz!");
                        }
                        else
                        {
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(textBox1.Text + " adlı kullanıcı zaten mevcut", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO loginData (username, password_u) VALUES (@username,@password)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 form1 = new Form1();
                                    form1.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı başarısız: " + ex, "Error Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Kullanıcı Adı Boş Bırakılamaz!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Şifre Boş Bırakılamaz!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false
                    ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }
    }
}
