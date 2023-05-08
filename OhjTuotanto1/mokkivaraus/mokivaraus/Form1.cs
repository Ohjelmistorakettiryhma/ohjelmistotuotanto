using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;
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
           

        }

        private void button18_Click(object sender, EventArgs e) // laskutus, poista -nappi
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e) // Tallenna PDF-muotoon -buttoni
        {
            
        }

        private void button29_Click(object sender, EventArgs e) // pitäis tulla kaikki lasku data datagridviewiin mutta meni moti niin päivitin paskaa sinne tietoihin.
        {

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
                decimal.TryParse(tblaskuid_hae.Text, out alv))
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
                tblaskuid_hae.Clear();
            }

            string hae = "SELECT * FROM lasku";
            MySqlCommand com = new MySqlCommand(hae, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_tallennapdf.DataSource = table;
        }

        private void button14_Click(object sender, EventArgs e)
        {
			Form6 form6 = new Form6(); // Create a new instance of the Form6 class
			form6.Show(); // Show the new form
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

        private void button3_Click(object sender, EventArgs e)
        {
            
             if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                // TODO: Use the selectedRow to delete the corresponding record from the database

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);


                MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");
                connection.Open();
                string query = "DELETE FROM mokki WHERE mokki_id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Mökki poistettu");
                }
                else
                {
                    MessageBox.Show("Mökkiä ei löydy");
                    

                }
                connection.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnHae_laskutusIDlla_Click(object sender, EventArgs e)
        {
            try
            {
                int laskuid = int.Parse(tblaskuid_hae.Text);

                string hakeminen = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi FROM lasku JOIN varaus ON lasku.varaus_id = varaus.varaus_id JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id WHERE lasku_id = @laskuid";

                MySqlCommand mySqlCommand = new MySqlCommand(hakeminen, connection);
                mySqlCommand.Parameters.AddWithValue("@laskuid", laskuid);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView_tallennapdf.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Tarkista syöte!");
            }
        }

        private void button32_Click(object sender, EventArgs e) // näytä olemassa olevat
        {
            string hakeminen = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, " +
               "varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi FROM lasku JOIN varaus ON lasku.varaus_id = varaus.varaus_id JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id";

            MySqlCommand command = new MySqlCommand(hakeminen, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView_tallennapdf.DataSource = table;
        }

        private void button34_Click(object sender, EventArgs e) // muokkaa tila
        {
            // Seuraavaksi muokataan laskun tila sen mukaan, mikä radiobutton on painettu. Sen jälkeen tulee vielä sen laskuid:n laskun tiedot päivitettynä näkyviin.
            try
            {

                int laskuid = int.Parse(tblaskuid_hae.Text);
                string paivita = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi FROM lasku JOIN varaus ON lasku.varaus_id = varaus.varaus_id JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id WHERE lasku_id = @laskuid";

                if (rbMaksamaton.Checked == true)
                {
                    try
                    {

                        //Muokataan tieto tila -kohtaan.
                        string muokkaaminen = "UPDATE lasku SET tila = 0 WHERE lasku_id = @laskuid";
                        MySqlCommand mySqlCommand = new MySqlCommand(muokkaaminen, connection);
                        mySqlCommand.Parameters.AddWithValue("@laskuid", laskuid);
                        connection.Open();
                        mySqlCommand.ExecuteNonQuery();
                        connection.Close();
                        //Näytetään taulukossa tila -muutos ja muut tiedot valitusta sarakkeesta.
                        MySqlCommand mySqlCommand1 = new MySqlCommand(paivita, connection);
                        mySqlCommand1.Parameters.AddWithValue("@laskuid", laskuid);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand1);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView_tallennapdf.DataSource = table;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Laskun tilan muokkaaminen epäonnistui!");
                    }

                }
                else if (rbMaksettu.Checked)
                {
                    try
                    {
                        //Muokataan tieto tila -kohtaan.
                        string muokkaaminen = "UPDATE lasku SET tila = '1' WHERE lasku_id = @laskuid";
                        MySqlCommand mySqlCommand = new MySqlCommand(muokkaaminen, connection);
                        mySqlCommand.Parameters.AddWithValue("@laskuid", laskuid);
                        connection.Open();
                        mySqlCommand.ExecuteNonQuery();
                        connection.Close();
                        //Näytetään taulukossa tila -muutos ja muut tiedot valitusta sarakkeesta.
                        MySqlCommand mySqlCommand1 = new MySqlCommand(paivita, connection);
                        mySqlCommand1.Parameters.AddWithValue("@laskuid", laskuid);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand1);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView_tallennapdf.DataSource = table;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Laskun tilan muokkaaminen epäonnistui!");
                    }
                }
                else if (rbEraantynyt.Checked)
                {
                    try
                    {
                        //Muokataan tieto tila -kohtaan.
                        string muokkaaminen = "UPDATE lasku SET tila = '2' WHERE lasku_id = @laskuid";
                        MySqlCommand mySqlCommand = new MySqlCommand(muokkaaminen, connection);
                        mySqlCommand.Parameters.AddWithValue("@laskuid", laskuid);
                        connection.Open();
                        mySqlCommand.ExecuteNonQuery();
                        connection.Close();
                        //Näytetään taulukossa tila -muutos ja muut tiedot valitusta sarakkeesta.
                        MySqlCommand mySqlCommand1 = new MySqlCommand(paivita, connection);
                        mySqlCommand1.Parameters.AddWithValue("@laskuid", laskuid);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand1);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView_tallennapdf.DataSource = table;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Laskun tilan muokkaaminen epäonnistui!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Laskun tilan muokkaaminen epäonnistui, valitse tila!");
            }
        }

        private void button33_Click(object sender, EventArgs e) // tallenna pdf
        {
            try
            {

                int laskuid = int.Parse(tblaskuid_hae.Text);
                //Haetaan tiedot datagridviewiin siitä laskusta, jonka ID syötetty tblaskuid_hae:seen.
                string Hakeminen = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi FROM lasku JOIN varaus ON lasku.varaus_id = varaus.varaus_id JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id WHERE lasku_id = @laskuid";
                MySqlCommand mySqlCommand1 = new MySqlCommand(Hakeminen, connection);
                mySqlCommand1.Parameters.AddWithValue("@laskuid", laskuid);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand1);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView_tallennapdf.DataSource = table;

                //Haetaan tiedot tietokannasta ja laitetaan ne muuttujiin, jotta voidaan käyttää niitä pdf-tiedostossa.
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(Hakeminen, connection))
                {
                    command.Parameters.AddWithValue("@laskuid", laskuid);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    { // kaikki muuttujat muokataan käytettäviksi laskuun
                        string etunimi = reader.GetString(reader.GetOrdinal("etunimi"));
                        string sukunimi = reader.GetString(reader.GetOrdinal("sukunimi"));
                        int varausid = reader.GetInt32(reader.GetOrdinal("varaus_id"));
                        string varausidString = varausid.ToString();
                        DateTime Alkupvm = reader.GetDateTime(reader.GetOrdinal("varattu_alkupvm"));
                        string AlkupvmString = Alkupvm.ToString("dd.MM.yyyy");
                        DateTime Loppupvm = reader.GetDateTime(reader.GetOrdinal("varattu_loppupvm"));
                        string LoppupvmString = Loppupvm.ToString("dd.MM.yyyy");
                        string mokkinimi = reader.GetString(reader.GetOrdinal("mokkinimi"));
                        string palvelunnimi = reader.GetString(reader.GetOrdinal("palvelun_nimi"));
                        decimal summa = reader.GetDecimal(reader.GetOrdinal("summa"));
                        string summaString = summa.ToString();
                        decimal alv = reader.GetDecimal(reader.GetOrdinal("alv"));
                        string alvString = alv.ToString();
                        DateTime erapaiva = reader.GetDateTime(reader.GetOrdinal("erapv"));
                        string erapaivaString = erapaiva.ToString("dd.MM.yyyy");

                        Document dokumentti = new Document();
                        string polku = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\LaskuPdf.pdf";
                        PdfWriter.GetInstance(dokumentti, new FileStream(polku, FileMode.Create));
                        dokumentti.Open();
                        Paragraph laskuntiedot1 = new Paragraph();
                        Paragraph laskuntiedot2 = new Paragraph();
                        Paragraph laskuntiedot3 = new Paragraph();
                        Paragraph tyhja = new Paragraph("\n");
                        laskuntiedot1.Add("PDF lasku");
                        dokumentti.Add(tyhja);
                        dokumentti.Add(tyhja);
                        dokumentti.Add(tyhja);
                        laskuntiedot2.Add(new Chunk("\nNimi: "));
                        laskuntiedot2.Add(new Chunk(etunimi + " " + sukunimi));
                        laskuntiedot2.Add(new Chunk("\nVaraus ID: "));
                        laskuntiedot2.Add(new Chunk(varausidString));
                        laskuntiedot2.Add(new Chunk("\nMökki: "));
                        laskuntiedot2.Add(new Chunk(mokkinimi));
                        laskuntiedot2.Add(new Chunk("\nVarauksen alku päivämäärä: "));
                        laskuntiedot2.Add(new Chunk(AlkupvmString));
                        laskuntiedot2.Add(new Chunk("\nVarauksen loppu päivämäärä: "));
                        laskuntiedot2.Add(new Chunk(LoppupvmString));
                        laskuntiedot2.Add(new Chunk("\nLisäpalvelut: "));
                        laskuntiedot2.Add(new Chunk(palvelunnimi));


                        laskuntiedot3.Add(new Chunk("\nLaskun summa: "));
                        laskuntiedot3.Add(new Chunk(summaString));

                        laskuntiedot3.Add(new Chunk("\nALV: "));
                        laskuntiedot3.Add(new Chunk(alvString));

                        laskuntiedot3.Add(new Chunk("\nLaskun eräpäivä: "));
                        laskuntiedot3.Add(new Chunk(erapaivaString));

                        //laskuun laitetaan kaikki tiedot ja muutamat tyhjät rivit. Luodaan dokumentti ja se tulee heti näkyviin. Lisäksi messagebox ilmoittaa, että lasku tosiaan onnistui.

                        dokumentti.Add(laskuntiedot1);
                        dokumentti.Add(tyhja);
                        dokumentti.Add(tyhja);
                        dokumentti.Add(laskuntiedot2);
                        dokumentti.Add(tyhja);
                        dokumentti.Add(laskuntiedot3);
                        dokumentti.Close();
                        Process.Start(polku);
                        MessageBox.Show("Pdf-tiedosto luotu onnistuneesti!");


                    }
                }
            }
            catch // jos ei onnistu tietojen hakeminen ja dokumentin luominen niin tullaan tähän.
            {
                MessageBox.Show("PDF-tiedoston luonti epäonnistui, yritä uudelleen.");
            }
        }

        private void btnMuokkaaVaraus_Click(object sender, EventArgs e) // varaus, muokkaa
        {
            // seuraavaksi muutetaan oikeaan muotoon päivämäärät.
            DateTime varattuPvm = dtpvarattu.Value;
            string Pvm1 = varattuPvm.ToString("yyyy-MM-dd");

            DateTime vahvistusPvm = dtpvahvistus.Value;
            string Pvm2 = vahvistusPvm.ToString("yyyy-MM-dd");

            DateTime varattuAlkuPvm = dtpvarattuAlku.Value;
            string Pvm3 = varattuAlkuPvm.ToString("yyyy-MM-dd");

            DateTime varattuLoppuPvm = dtpvarattuLoppu.Value;
            string Pvm4 = varattuLoppuPvm.ToString("yyyy-MM-dd");

            DateTime PVM1 = DateTime.ParseExact(Pvm1, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime PVM2 = DateTime.ParseExact(Pvm2, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime PVM3 = DateTime.ParseExact(Pvm3, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime PVM4 = DateTime.ParseExact(Pvm4, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            try
            {
                //seuraavaksi päivitetään varaus tietokantaan.

                int asiakasid = int.Parse(tbAsiakasidMuokkaa.Text);
                int mokkiid = int.Parse(tbMokkiidMuokkaa.Text);
                int varausid = int.Parse(tbVarausid_varaus.Text);
                string muokkaa = "UPDATE VARAUS SET asiakas_id = @asiakasid, mokki_mokki_id = @mokkiid, varattu_pvm = @varattupvm, vahvistus_pvm = @vahvistuspvm, varattu_alkupvm = @alkupvm, varattu_loppupvm = @loppupvm WHERE varaus_id = @varausid";
                MySqlCommand command = new MySqlCommand(muokkaa, connection);
                command.Parameters.AddWithValue("@asiakasid", asiakasid);
                command.Parameters.AddWithValue("@mokkiid", mokkiid);
                command.Parameters.AddWithValue("@varattupvm", PVM1);
                command.Parameters.AddWithValue("@vahvistuspvm", PVM2);
                command.Parameters.AddWithValue("@alkupvm", PVM3);
                command.Parameters.AddWithValue("@loppupvm", PVM4);
                command.Parameters.AddWithValue("@varausid", varausid);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Tietojen päivitys onnistui.");

            }
            catch
            {
                MessageBox.Show("Muokkaaminen epäonnistui!");
            }
        }

        private void btnHae_varaus_Click(object sender, EventArgs e) // hae -nappi, varaus
        {
            //Tässä haetaan kaikki varaus, jonka varausid on syötetty textboxiin.

            try
            {
                int varausid = int.Parse(tbHaeVarausID.Text);

                string hakeminen = "SELECT a.etunimi, a.sukunimi, v.varaus_id, a.email, l.summa, l.tila, l.erapv,\r\n       m.mokkinimi, v.varattu_pvm, v.vahvistus_pvm, v.varattu_alkupvm, v.varattu_loppupvm\r\nFROM varaus v \r\nJOIN asiakas a ON v.asiakas_id = a.asiakas_id \r\nJOIN lasku l ON v.varaus_id = l.varaus_id \r\nJOIN mokki m ON v.mokki_mokki_id = m.mokki_id WHERE v.varaus_id = @varausid";

                MySqlCommand mySqlCommand = new MySqlCommand(hakeminen, connection);
                mySqlCommand.Parameters.AddWithValue("@varausid", varausid);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView_varaus.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Varausta ei löytynyt, yritä uudelleen!");
            }
        }

        private void btnNaytaVaraukset_Click(object sender, EventArgs e) // näyttää kaikki varaukset
        {
            //tässä haetaan kaikki varaukset ja näytetään ne datagridviewissä
            string hakeminen = "SELECT a.etunimi, a.sukunimi, v.varaus_id, a.email, l.summa, l.tila, l.erapv,\r\n       m.mokkinimi, v.varattu_pvm, v.vahvistus_pvm, v.varattu_alkupvm, v.varattu_loppupvm\r\nFROM varaus v \r\nJOIN asiakas a ON v.asiakas_id = a.asiakas_id \r\nJOIN lasku l ON v.varaus_id = l.varaus_id \r\nJOIN mokki m ON v.mokki_mokki_id = m.mokki_id";

            MySqlCommand command = new MySqlCommand(hakeminen, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView_varaus.DataSource = table;
        }

		private void button15_Click(object sender, EventArgs e)
		{
			if (dataGridView3.SelectedRows.Count > 0)
			{

				DataGridViewRow selectedRow = dataGridView3.SelectedRows[0];
				// TODO: Use the selectedRow to delete the corresponding record from the database

				int id = Convert.ToInt32(selectedRow.Cells[0].Value);


				MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");
				connection.Open();
				string query = "DELETE FROM asiakas WHERE asiakas_id = @id";
				MySqlCommand command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@id", id);

				int rowsAffected = command.ExecuteNonQuery();
				connection.Close();
				if (rowsAffected > 0)
				{
					MessageBox.Show("Asiakas poistettu");
				}
				else
				{
					MessageBox.Show("Asiakasta ei löydy");


				}
				connection.Close();
			}
		}
	}
}
