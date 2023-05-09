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

namespace mokivaraus
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");

        private void button2_Click(object sender, EventArgs e)
        {
            int laskuid = int.Parse(tblaskuid.Text);
            int varausid = int.Parse(tbvarausid.Text);
            DateTime erapv = dtperapv.Value;
            string EraPv = erapv.ToString("yyyy-MM-dd");
            int tila = 0;

            DateTime ERAPV = DateTime.ParseExact(EraPv, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            try
            {

                if (rbMaksamaton.Checked == true)
                {
                    tila = 0;
                }
                else if (rbMaksettu.Checked == true)
                {
                    tila = 1;
                }
                else if (rbEraantynyt.Checked == true)
                {
                    tila = 2;
                }
                else
                {
                    MessageBox.Show("Valitse laskun tila!");
                }


                connection.Open();


                connection.Close();

                string lisaaminen = "INSERT INTO lasku (lasku_id, varaus_id, summa, alv, tila, erapv)\r\nSELECT @laskuid, @varausid, m.hinta + (p.hinta * vp.lkm), p.alv, @tila, @erapv\r\nFROM varaus v\r\nINNER JOIN mokki m ON v.mokki_mokki_id = m.mokki_id\r\nINNER JOIN varauksen_palvelut vp ON v.varaus_id = vp.varaus_id\r\nINNER JOIN palvelu p ON vp.palvelu_id = p.palvelu_id\r\nWHERE v.varaus_id = @varausid";


                // haetaan summa ja alv labeleihin

                string hakeminen = "SELECT summa, alv FROM lasku WHERE varaus_id = @varausid";
                MySqlCommand command = new MySqlCommand(lisaaminen, connection);

                command.Parameters.AddWithValue("@laskuid", int.Parse(tblaskuid.Text));
                command.Parameters.AddWithValue("@varausid", int.Parse(tbvarausid.Text));
                command.Parameters.AddWithValue("@tila", tila);
                command.Parameters.AddWithValue("@erapv", erapv);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MySqlCommand command1 = new MySqlCommand(hakeminen, connection);

                command1.Parameters.AddWithValue("@varausid", int.Parse(tbvarausid.Text));

                connection.Open();

                // haetaan tietokannasta summa ja alv.
                MySqlDataReader reader = command1.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        decimal summa = reader.GetDecimal(0);
                        decimal alv = reader.GetDecimal(1);

                        lbSumma.Text = summa.ToString();
                        lbALV.Text = alv.ToString();

                    }
                    reader.Close();

                }

                connection.Close();

                connection.Open();

                //Haetaan vielä lopuksi tietokannasta varausidllä lisätty lasku.

                string Hakeminen = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi FROM lasku JOIN varaus ON lasku.varaus_id = varaus.varaus_id JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id WHERE varaus.varaus_id = @varausid";
                MySqlCommand mySqlCommand = new MySqlCommand(Hakeminen, connection);
                mySqlCommand.Parameters.AddWithValue("@varausid", varausid);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView_lisaalasku.DataSource = table;

                connection.Close();

            }
            catch
            {
                MessageBox.Show("Laskun lisääminen epäonnistui, yritä uudelleen.");
                tblaskuid.Clear();
                tbvarausid.Clear();
                lbALV.Text = "0";
                lbSumma.Text = "0";
            }
        }

        private void btnNaytaKaikki_Click(object sender, EventArgs e)
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
