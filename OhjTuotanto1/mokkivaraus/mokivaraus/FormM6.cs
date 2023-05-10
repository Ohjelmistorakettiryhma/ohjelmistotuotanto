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
	public partial class FormM6 : Form
	{
		private string asiakasid;
		private string postinro;
		private string etunimi;
		private string sukunimi;
		private string lahiosoite;
		private string email;
		private string puhelinnro;
		
		public FormM6(string asiakasid, string postinro, string etunimi, string sukunimi, string lahiosoite, string email, string puhelinnro)
		{
			InitializeComponent();

			this.asiakasid = asiakasid;
			this.postinro = postinro;
			this.etunimi = etunimi;
			this.sukunimi = sukunimi;
			this.lahiosoite = lahiosoite;
			this.email = email;
			this.puhelinnro = puhelinnro;
		}

		MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");

		private void FormM6_Load(object sender, EventArgs e)
		{
			// näytetään edelliseltä sivulta otetut tiedot uuden formin textboxeissa
			tbasiakasid2_asiakas.Text = asiakasid;
			tbpostinro2_asiakas.Text = postinro;
			tbetunimi2_asiakas.Text = etunimi;
			tbsukunimi2_asiakas.Text = sukunimi;
			tblahiosoite2_asiakas.Text = lahiosoite;
			tbemail2_asiakas.Text = email;
			tbpuhelinnro2_asiakas.Text = puhelinnro;

			// haetaan myös asiakkaaseen liittyvä postitoimipaikka esille postitaulusta
			using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;"))
			{
				connection.Open();

				string query = "SELECT toimipaikka FROM posti WHERE postinro = @postinro";
				MySqlCommand command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@postinro", postinro);

				using(MySqlDataReader reader = command.ExecuteReader())
				{
					if(reader.Read())
					{
						// haetaan kaupunki
						string kaupunki = reader.GetString("posti");
						
						// laitetaan esille textboxiin
						tbkaupunki2_asiakas.Text = kaupunki;
					}
				}
				
				connection.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// tallennetaan muokatut tiedot
			string asiakasid_muokattu = tbasiakasid2_asiakas.Text;
			string postinro_muokattu = tbpostinro2_asiakas.Text;
			string etunimi_muokattu = tbetunimi2_asiakas.Text;
			string sukunimi_muokattu = tbsukunimi2_asiakas.Text;
			string lahiosoite_muokattu = tblahiosoite2_asiakas.Text;
			string email_muokattu = tbemail2_asiakas.Text;
			string puhelinnro_muokattu = tbpuhelinnro2_asiakas.Text;
			string kaupunki_muokattu = tbkaupunki2_asiakas.Text;

			// päivitetään muokatut tiedot tietokantaan
			string muokattuQuery1 = "UPDATE posti SET toimipaikka = @toimipaikka WHERE postinro = @postinro";
			string muokattuQuery2 = "UPDATE asiakas SET postinro = @postinro, etunimi = @etunimi, sukunimi = @sukunimi, lahiosoite = @lahiosoite, email = @email, puhelinnro = @puhelinnro WHERE asiakas_id = @asiakasid";
			using (MySqlConnection connection2 = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;"))
			{
				using (MySqlCommand command2 = new MySqlCommand(muokattuQuery1, connection2))
				{
					command2.Parameters.AddWithValue("@toimipaikka", kaupunki_muokattu);
					command2.Parameters.AddWithValue("@postinro", postinro_muokattu);

					connection2.Open();
					command2.ExecuteNonQuery();
					connection2.Close();
				}
				using (MySqlCommand command3 = new MySqlCommand(muokattuQuery2, connection2))
				{
					command3.Parameters.AddWithValue("@postinro", postinro_muokattu);
					command3.Parameters.AddWithValue("@etunimi", etunimi_muokattu);
					command3.Parameters.AddWithValue("@sukunimi", sukunimi_muokattu);
					command3.Parameters.AddWithValue("@lahiosoite", lahiosoite_muokattu);
					command3.Parameters.AddWithValue("@email", email_muokattu);
					command3.Parameters.AddWithValue("@puhelinnro", puhelinnro_muokattu);
					command3.Parameters.AddWithValue("@asiakasid", asiakasid_muokattu);

					connection2.Open();
					command3.ExecuteNonQuery();
					connection2.Close();
				}
			}
		}
	}
}
