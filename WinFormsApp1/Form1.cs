using System.Diagnostics.Tracing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using OpenQA.Selenium.DevTools.V140.FedCm;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\emrea\\Documents\\deneme.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public Form1()
        {

            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    String selectData = "SELECT * FROM loginData WHERE username= @username AND password_u= @password";
                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@password", textBox2.Text);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (textBox1.Text == "")
                            {
                                errorProvider1.SetError(textBox1, "Kullanýcý Adý Boþ Býrakýlamaz!");
                            }
                            if (textBox2.Text == "")
                            {
                                errorProvider2.SetError(textBox2, "Þifre Boþ Býrakýlamaz!");
                            }

                            if (table.Rows.Count >= 1)
                            {
                                Form4 form4 = new Form4();
                                form4.Show();
                                this.Hide();


                            }
                            else
                            {

                                MessageBox.Show("Kullanýcý Adý/Þifre Yanlýþ!", "Error Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabaný baðlantýsý baþarýsýz: " + ex, "Error Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();

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

        private void label7_Click(object sender, EventArgs e)
        {
            if (Form1.ActiveForm.WindowState is FormWindowState.Normal)
            {
                Form1.ActiveForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                Form1.ActiveForm.WindowState = FormWindowState.Normal;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Kullanýcý Adý Boþ Býrakýlamaz!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Þifre Boþ Býrakýlamaz!");
            }
        }
    }
}
