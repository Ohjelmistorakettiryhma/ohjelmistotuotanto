using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace mokivaraus
{
    
    public partial class Form1 : Form
    {
     
       
        public Form1()
        {
            InitializeComponent();
        }

       // MySqlConnection connection = new MySqlConnection("Server=localhost; Database=vn; Uid=root; Pwd=Ruutti;");

        //string conString = "server=localhost;port=3307;database=vn;uid=root;password=Ruutti;";
        //// string connectionString = "datasource=localhost;port=3307;username=root;password=Ruutti;database=vn";
        //MySqlConnection yhteys = new MySqlConnection();
        //yhteys.ConnectionString = ConString;

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Create a new instance of the Form2 class
            form2.Show(); // Show the new form
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e) // laskutus, muokkaa -nappi
        {
            Form3 form3 = new Form3();  // Create a new instance of Form3
            form3.Show();               // Show Form3

        }

        private void button18_Click(object sender, EventArgs e) // laskutus, poista -nappi
        {
            Form4 form4 = new Form4();  // Create a new instance of Form4
            form4.Show();               // Show Form4
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e) // Tallenna PDF-muotoon -buttoni
        {
            Form5 form5 = new Form5();  // Create a new instance of Form5
            form5.Show();               // Show Form5
        }

        private void button29_Click(object sender, EventArgs e) // pitäis tulla kaikki lasku data datagridviewiin mutta meni moti niin päivitin paskaa sinne tietoihin.
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");
            string query = "INSERT INTO posti(postinro, toimipaikka) VALUES (@postinro,@toimipaikka);";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@postinro", "98374");
            command.Parameters.AddWithValue("@toimipaikka", "TESTI");
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
}
}
