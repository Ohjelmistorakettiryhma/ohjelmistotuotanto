using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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


        private void button_muokkaa_nayta_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM lasku";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_tallenna_laskutus.DataSource = table;
        }

        private void btn_muokkaa_muokkaa_Click(object sender, EventArgs e) //tallenna -nappi
        {
            // Tämä koodi olettaa, että olet jo hakenut tarvittavat tiedot tietokannasta
            // ja tallentanut ne muuttujiin.

            string query = "SELECT asiakas.etunimi, asiakas.sukunimi, lasku.*, varaus.varattu_alkupvm, varaus.varattu_loppupvm, mokki.mokkinimi, palvelu.nimi AS palvelun_nimi" +
                            "FROM lasku" +
                            "JOIN varaus ON lasku.varaus_id = varaus.varaus_id" +
                            "JOIN asiakas ON varaus.asiakas_id = asiakas.asiakas_id" +
                            "JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id" +
                            "INNER JOIN varauksen_palvelut ON varaus.varaus_id = varauksen_palvelut.varaus_id" +
                            "INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id" +
                            "WHERE lasku.lasku_id = 1";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@lasku_id", int.Parse(tbLasku_id_tallenna.Text));
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Luodaan PDF-tiedosto
            string fileName = "lasku" + tbLasku_id_tallenna.Text + ".pdf";
            string filePath = @"C:\Asiakas_laskut\" + fileName;
            FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            //Document document = new Document();
            //PdfWriter writer = PdfWriter.GetInstance(document, file);
            //document.Open();

            //// Lisätään laskun tiedot PDF-tiedostoon
            //Paragraph title = new Paragraph("Lasku " + tbLasku_id_tallenna.Text);
            //document.Add(title);

            //Paragraph asiakasNimi = new Paragraph("Asiakas: " + table.Rows[0]["asiakkaan_etunimi"].ToString() + " " + table.Rows[0]["asiakkaan_sukunimi"].ToString());
            //document.Add(asiakasNimi);

            //Paragraph alueenNimi = new Paragraph("Alue: " + table.Rows[0]["alueen_nimi"].ToString());
            //document.Add(alueenNimi);

            //Paragraph mokkiNimi = new Paragraph("Mökki: " + table.Rows[0]["mokkinimi"].ToString());
            //document.Add(mokkiNimi);

            //Paragraph summa = new Paragraph("Summa: " + table.Rows[0]["summa"].ToString());
            //document.Add(summa);

            //Paragraph alv = new Paragraph("ALV: " + table.Rows[0]["alv"].ToString());
            //document.Add(alv);

            //document.Close();
            //writer.Close();


            //// Luo uusi PDF-dokumentti
            //Document document = new Document();

            //// Määritä PDF-tiedoston nimi ja sijainti
            //string filePath = @"C:\Users\käyttäjänimi\Documents\lasku.pdf";

            //// Luo uusi PDF-tiedosto ja aseta se tallentamaan yllä määritettyyn sijaintiin
            //PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            //// Avaa PDF-dokumentti
            //document.Open();

            //// Lisää laskun tiedot PDF-dokumenttiin
            //document.Add(new Paragraph("Laskun tiedot:"));
            //document.Add(new Paragraph($"Lasku ID: {laskuId}"));
            //document.Add(new Paragraph($"Asiakkaan nimi: {asiakasEtunimi} {asiakasSukunimi}"));
            //document.Add(new Paragraph($"Alueen nimi: {alueNimi}"));
            //document.Add(new Paragraph($"Mökin nimi: {mokkiNimi}"));
            //document.Add(new Paragraph($"Summa: {summa}"));
            //document.Add(new Paragraph($"ALV: {alv}"));

            //// Sulje PDF-dokumentti
            //document.Close();

            //// Avaa PDF-tiedosto automaattisesti oletus PDF-lukijassa
            //Process.Start(filePath);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
