﻿using System;
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
using MySqlConnector;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;
using mokivaraus.Properties;
using MySqlConnection = MySqlConnector.MySqlConnection;
using MySqlCommand = MySqlConnector.MySqlCommand;
using MySqlDataAdapter = MySqlConnector.MySqlDataAdapter;
using MySqlDataReader = MySqlConnector.MySqlDataReader;
using System.Linq.Expressions;

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
			try
			{


				MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");

				connection.Open();
				// Tarkistaa onko postinumero jo olemassa tietokannassa
				string queryTarkistaPostinro = "SELECT COUNT(*) FROM posti WHERE postinro = @postinro";
				MySqlCommand commandTarkistaPostinro = new MySqlCommand(queryTarkistaPostinro, connection);
				commandTarkistaPostinro.Parameters.AddWithValue("@postinro", tbpostinro_asiakas.Text);

				int count = Convert.ToInt32(commandTarkistaPostinro.ExecuteScalar());

				if (count == 0)
				{
					// Postinumeroa ei ole olemassa, lisätään uusi postinumero ja toimipaikka tietokantaan
					string queryLisaaPostinro = "INSERT INTO posti (postinro, toimipaikka) VALUES (@postinro, @toimipaikka)";
					MySqlCommand commandLisaaPostinro = new MySqlCommand(queryLisaaPostinro, connection);

					commandLisaaPostinro.Parameters.AddWithValue("@postinro", tbpostinro_asiakas.Text);
					commandLisaaPostinro.Parameters.AddWithValue("@toimipaikka", tbkaupunki_asiakas.Text);
					commandLisaaPostinro.ExecuteNonQuery();
				}
				else
				{
					// Lisätään uusi asiakasdata asiakastauluun
					string queryLisaaAsiakas = "INSERT INTO asiakas (asiakas_id, postinro, etunimi, sukunimi, lahiosoite, puhelinnro, email) VALUES (@asiakasid, @postinro, @etunimi, @sukunimi, @lahiosoite, @puhelinnro, @email)";
					MySqlCommand commandLisaaAsiakas = new MySqlCommand(queryLisaaAsiakas, connection);

					int asiakasid;
					string etunimi, sukunimi, postinro, lahiosoite, puhelinnro, email;

					if (int.TryParse(tbasiakasid_asiakas.Text, out asiakasid))
					{
						commandLisaaAsiakas.Parameters.AddWithValue("@asiakasid", asiakasid);
						commandLisaaAsiakas.Parameters.AddWithValue("@postinro", tbpostinro_asiakas.Text);
						commandLisaaAsiakas.Parameters.AddWithValue("@etunimi", tbetunimi_asiakas.Text);
						commandLisaaAsiakas.Parameters.AddWithValue("@sukunimi", tbsukunimi_asiakas.Text);
						commandLisaaAsiakas.Parameters.AddWithValue("@lahiosoite", tblahiosoite_asiakas.Text);
						commandLisaaAsiakas.Parameters.AddWithValue("@puhelinnro", tbpuhelinnro_asiakas.Text);
						commandLisaaAsiakas.Parameters.AddWithValue("@email", tbemail_asiakas.Text);

						commandLisaaAsiakas.ExecuteNonQuery();

						connection.Close();

						MessageBox.Show("Asiakas lisätty");
					}

					else
					{
						MessageBox.Show("Väärät syötteet");
						tbasiakasid_asiakas.Clear();
						tbetunimi_asiakas.Clear();
						tbsukunimi_asiakas.Clear();
						tbpostinro_asiakas.Clear();
						tblahiosoite_asiakas.Clear();
						tbpuhelinnro_asiakas.Clear();
						tbemail_asiakas.Clear();
						tbkaupunki_asiakas.Clear();
					}
				}
			}
			catch
			{
				MessageBox.Show("Asiakkaan lisäys epäonnistui");
			}
			/*catch
			{
				MessageBox.Show("Asiakkaan lisääminen epäonnistui");
			}*/

		}
	}
}
