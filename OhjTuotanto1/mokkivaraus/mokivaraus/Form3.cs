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

namespace mokivaraus
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button_muokkaa_nayta_Click(object sender, EventArgs e) //form3 muokkaa -nappi
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");

            string query = "SELECT * FROM lasku";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_muokkaa_laskutus.DataSource = table;
        }

        private void btn_muokkaa_muokkaa_Click(object sender, EventArgs e) // muokkaa -välilehden muokkaa -nappi
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("UPDATE lasku SET varaus_id = @varaus_id, summa = @summa, alv = @alv WHERE lasku_id = @lasku_id", connection);

                command.Parameters.AddWithValue("@lasku_id", int.Parse(tbLaskuid_Muokkaa.Text)); ;
                command.Parameters.AddWithValue("@varaus_id", int.Parse(tbVarausid_muokkaa.Text)); ;
                command.Parameters.AddWithValue("@summa", decimal.Parse(tbsumma_muokkaa.Text));
                command.Parameters.AddWithValue("@alv", decimal.Parse(tbalv_muokkaa.Text));

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    string query = "SELECT * FROM lasku";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView_muokkaa_laskutus.DataSource = table;

                    MessageBox.Show("Muokkaaminen onnistui!");
                }
                else
                {
                    MessageBox.Show("Muokkaaminen epäonnistui. Laskua ei löytynyt tietokannasta.");
                    tbLaskuid_Muokkaa.Clear();
                    tbVarausid_muokkaa.Clear();
                    tbsumma_muokkaa.Clear();
                    tbalv_muokkaa.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }

        private void tbLaskuid_Muokkaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkistaa että syötetty merkki on numero
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Tarkistaa että teksti ei ole yli sallitun pituuden
            TextBox textBox = sender as TextBox;
            int maxLength = 0;
            switch (textBox.Name)
            {
                case "tbLaskuid_Muokkaa":
                    maxLength = 11; // lasku_id int(11)
                    break;
                case "tbVarausid_muokkaa":
                    maxLength = 10; // varaus_id int(10)
                    break;
                case "tbsumma_muokkaa":
                    maxLength = 10; // summa double(8,2)
                    break;
                case "tbalv_muokkaa":
                    maxLength = 10; // alv double(8,2)
                    break;
                default:
                    break;
            }
            if (textBox.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbVarausid_muokkaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkistaa että merkki on numero
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Tarkistaa, että tekstikenttä ei ole yli sallitun pituuden
            TextBox textBox = sender as TextBox;
            int maxLength = 0;
            switch (textBox.Name)
            {
                case "tbLaskuid_Muokkaa":
                    maxLength = 11; // lasku_id int(11)
                    break;
                case "tbVarausid_muokkaa":
                    maxLength = 10; // varaus_id int(10)
                    break;
                case "tbsumma_muokkaa":
                    maxLength = 10; // summa double(8,2)
                    break;
                case "tbalv_muokkaa":
                    maxLength = 10; // alv double(8,2)
                    break;
                default:
                    break;
            }
            if (textBox.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbsumma_muokkaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // onko syötetty vain numeroita tai piste
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // tarkistetaan et pisteitä on vaan yksi
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }

            // Tarkistaa että tekstikenttä ei ole yli sallitun pituuden
            TextBox textBox = sender as TextBox;
            int maxLength = 0;
            switch (textBox.Name)
            {
                case "tbLaskuid_Muokkaa":
                    maxLength = 11; // lasku_id int(11)
                    break;
                case "tbVarausid_muokkaa":
                    maxLength = 10; // varaus_id int(10)
                    break;
                case "tbsumma_muokkaa":
                    maxLength = 10; // summa double(8,2)
                    break;
                case "tbalv_muokkaa":
                    maxLength = 10; // alv double(8,2)
                    break;
                default:
                    break;
            }
            if (textBox.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbalv_muokkaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkista, että syötetty merkki on numeerinen tai backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }

            // Tarkista, että tekstikenttä ei ole yli sallitun pituuden
            TextBox textBox = sender as TextBox;
            int maxLength = 0;
            switch (textBox.Name)
            {
                case "tbLaskuid_Muokkaa":
                    maxLength = 11; // lasku_id int(11)
                    break;
                case "tbVarausid_muokkaa":
                    maxLength = 10; // varaus_id int(10)
                    break;
                case "tbsumma_muokkaa":
                    maxLength = 10; // summa double(8,2)
                    break;
                case "tbalv_muokkaa":
                    maxLength = 10; // alv double(8,2)
                    break;
                default:
                    break;
            }
            if (textBox.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
