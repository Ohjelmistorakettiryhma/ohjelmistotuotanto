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
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			connection.Open();

			string query = "INSERT INTO asiakas (asiakas_id, postinro, etunimi, sukunimi, lahiosoite, puhelinnro, email) VALUES (@asiakas_id, @postinumero, @etunimi, @sukunimi, @lahiosoite, @puhelinnro, @email)";
			MySqlCommand command = new MySqlCommand(query, connection);

			int asiakasid;
			string postinro, etunimi, sukunimi, lahiosoite, puhelinnro, email;

			if (int.TryParse(tbasiakasid_asiakas.Text, out asiakasid))
			{
				command.Parameters.AddWithValue("@asiakas_id", asiakasid);
				command.Parameters.AddWithValue("@postinro", tbpostinro_asiakas.Text);
				command.Parameters.AddWithValue("@etunimi", tbetunimi_asiakas.Text);
				command.Parameters.AddWithValue("@sukunimi", tbsukunimi_asiakas.Text);
				command.Parameters.AddWithValue("@lahiosoite", tblahiosoite_asiakas.Text);
				command.Parameters.AddWithValue("@puhelinnro", tbpuhelinnro_asiakas.Text);
				command.Parameters.AddWithValue("@email", tbemail_asiakas.Text);

				command.ExecuteNonQuery();

				connection.Close();

				MessageBox.Show("Asiakas lisätty");
			}
			else
			{
				MessageBox.Show("Väärät syötteet");
				tbasiakasid_asiakas.Clear();
				tbpostinro_asiakas.Clear();
				tbetunimi_asiakas.Clear();
				tbsukunimi_asiakas.Clear();
				tblahiosoite_asiakas.Clear();
				tbpuhelinnro_asiakas.Clear();
				tbemail_asiakas.Clear();
			}
		}
	}
}
