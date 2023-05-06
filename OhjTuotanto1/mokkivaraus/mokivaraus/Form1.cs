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


namespace mokivaraus
{
    
    public partial class Form1 : Form
    {
     
       
        public Form1()
        {
            InitializeComponent();
        }

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

        private void button17_Click(object sender, EventArgs e) // laskutus, hae -nappi
        {
            // Haetaan kaikki laskut datagridviewiin näkyviin.

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

        private void button18_Click(object sender, EventArgs e) // laskutus, muokkaa tila -nappi
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
                    catch(Exception ex)
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
                    catch(Exception ex)
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
                    catch(Exception ex)
                    {
                        MessageBox.Show("Laskun tilan muokkaaminen epäonnistui!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Laskun tilan muokkaaminen epäonnistui, valitse tila!");
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e) // Tallenna PDF-muotoon -buttoni
        {
            //TÄMÄ TUON ALLE SEURAAVAKSI

        }

        private void button29_Click(object sender, EventArgs e) // kaikki laskut datagridviewiin näkyviin
        {

            string hakeminen = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, " +
                "varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi FROM lasku JOIN varaus ON lasku.varaus_id = varaus.varaus_id JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id";

            MySqlCommand command = new MySqlCommand(hakeminen, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView_tallennapdf.DataSource = table;

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

        private void tbLaskuID_laskutus_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void tbVarausID_laskutus_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

            

        private void tbSumma_laskutus_KeyPress(object sender, KeyPressEventArgs e)
        {
          

        }

        private void tbALV_laskutus_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void tbhae_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rbMaksamaton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNaytaVaraukset_Click(object sender, EventArgs e) // Näytä kaikki varaukset -buttoni
        {
            //tässä haetaan kaikki varaukset ja näytetään ne datagridviewissä
            string hakeminen = "SELECT a.etunimi, a.sukunimi, v.varaus_id, a.email, l.summa, l.tila, l.erapv,\r\n       m.mokkinimi, v.varattu_pvm, v.vahvistus_pvm, v.varattu_alkupvm, v.varattu_loppupvm\r\nFROM varaus v \r\nJOIN asiakas a ON v.asiakas_id = a.asiakas_id \r\nJOIN lasku l ON v.varaus_id = l.varaus_id \r\nJOIN mokki m ON v.mokki_mokki_id = m.mokki_id";

            MySqlCommand command = new MySqlCommand(hakeminen, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView_varaus.DataSource = table;
        }

        private void btnHae_varaus_Click(object sender, EventArgs e)
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

        private void bnPoista_Click(object sender, EventArgs e) // varaus, poista-nappi
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnMuokkaaVaraus_Click(object sender, EventArgs e) // varaus, muokkaa-nappi
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

    }
}
