using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnection = MySqlConnector.MySqlConnection;
using MySqlCommand = MySqlConnector.MySqlCommand;
using MySqlDataAdapter = MySqlConnector.MySqlDataAdapter;
using MySqlDataReader = MySqlConnector.MySqlDataReader;

namespace mokivaraus
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");


        private void button1_Click(object sender, EventArgs e) // muokkaa eräpv
        {
            try
            {

                int laskuid = int.Parse(tbLaskuIDerapv.Text);
                DateTime erapv = dtpErapv.Value;
                string ERAPV = erapv.ToString("yyyy-MM-dd");
                DateTime erapaiva = DateTime.ParseExact(ERAPV, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                string muokkaa = "UPDATE LASKU SET erapv = @erapv WHERE lasku_id = @lasku_id";
                MySqlCommand command = new MySqlCommand(muokkaa, connection);
                command.Parameters.AddWithValue("@lasku_id", laskuid);
                command.Parameters.AddWithValue("@erapv", erapaiva);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Eräpäivän muuttaminen onnistui!");

                string hakeminen = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, " +
              "varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi FROM lasku JOIN varaus ON lasku.varaus_id = varaus.varaus_id JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id";

                MySqlCommand command2 = new MySqlCommand(hakeminen, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command2);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView_erapv.DataSource = table;

            }
            catch
            {
                MessageBox.Show("Eräpäivän muuttaminen epäonnistui.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // näytä kaikki laskut
        {
            string hakeminen = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, " +
              "varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi FROM lasku JOIN varaus ON lasku.varaus_id = varaus.varaus_id JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id";

            MySqlCommand command = new MySqlCommand(hakeminen, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView_erapv.DataSource = table;
        }
    }
}
