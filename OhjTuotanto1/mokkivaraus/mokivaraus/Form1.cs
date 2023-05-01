using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

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
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");

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
            
            string query = "SELECT * FROM lasku";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView4.DataSource = table;

        }

        private void button27_Click(object sender, EventArgs e) // lisää -painike laskutusosiossa.
        {
            string query = "INSERT INTO lasku (lasku_id, varaus_id, summa, alv) VALUES (@lasku_id, @varaus_id, @summa, @alv)";
            MySqlCommand command = new MySqlCommand(query, connection);

            int laskuid, varausid;
            decimal summa, alv;

            if (int.TryParse(tbLaskuID_laskutus.Text, out laskuid) &&
                int.TryParse(tbVarausID_laskutus.Text, out varausid) &&
                decimal.TryParse(tbSumma_laskutus.Text, out summa) &&
                decimal.TryParse(tbALV_laskutus.Text, out alv))
            {
                command.Parameters.AddWithValue("@lasku_id", laskuid);
                command.Parameters.AddWithValue("@varaus_id", varausid);
                command.Parameters.AddWithValue("@summa", summa);
                command.Parameters.AddWithValue("@alv", alv);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();

            }
            else
            {
                MessageBox.Show("Syötä kenttiin vain numeroita!");
                tbLaskuID_laskutus.Clear();
                tbVarausID_laskutus.Clear();
                tbSumma_laskutus.Clear();
                tbALV_laskutus.Clear();
            }

            string hae = "SELECT * FROM lasku";
            MySqlCommand com = new MySqlCommand(hae, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView4.DataSource = table;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");
            string query = "SELECT * FROM mokki";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
