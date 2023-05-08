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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");

        private void button2_Click(object sender, EventArgs e) // lisää lasku
        {
            // LISÄÄ KOODIA!!
            int laskuid = int.Parse(tblaskuid.Text);
            int varausid = int.Parse(tbvarausid.Text);

            string Hakeminen = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi FROM lasku JOIN varaus ON lasku.varaus_id = varaus.varaus_id JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id WHERE varaus_id = @varausid";
            MySqlCommand mySqlCommand = new MySqlCommand(Hakeminen, connection);
            mySqlCommand.Parameters.AddWithValue("@varausid", varausid);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView_lisaalasku.DataSource = table;

            //Haetaan tiedot tietokannasta ja laitetaan ne muuttujiin, jotta voidaan käyttää niitä pdf-tiedostossa.
            connection.Open();

            using (MySqlCommand command = new MySqlCommand(Hakeminen, connection))
            {
                command.Parameters.AddWithValue("@laskuid", laskuid);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                { // kaikki muuttujat muokataan käytettäviksi laskuun
                    MySqlCommand cmd = new MySqlCommand(Hakeminen, connection);
                    cmd.Parameters.AddWithValue("@varausid", varausid);
                    int varausID = reader.GetInt32(reader.GetOrdinal("varaus_id"));
                    string varausidString = varausID.ToString();

                }

            }
        }
        private void btnNaytaKaikki_Click(object sender, EventArgs e) // näytä kaikki laskut
        {
            string hakeminen = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, " +
               "varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi FROM lasku JOIN varaus ON lasku.varaus_id = varaus.varaus_id JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id";

            MySqlCommand command = new MySqlCommand(hakeminen, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView_lisaalasku.DataSource = table;
        }
    }
}
