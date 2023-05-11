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

namespace mokivaraus.Properties
{
    public partial class PalvelunlisaysForm : Form
    {
        public PalvelunlisaysForm()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "INSERT INTO palvelu (palvelu_id, alue_id, nimi, tyyppi, kuvaus, hinta, alv) VALUES (@palvelu_id, @alue_id, @nimi, @tyyppi, @kuvaus, @hinta, @alv)";
                MySqlCommand command = new MySqlCommand(query, connection);

                int palveluid, alueid, tyyppi;
                double hinta, alv;
                string nimi, kuvaus;

                if (int.TryParse(tbpalveluid.Text, out palveluid) &&
                    int.TryParse(tbalueid.Text, out alueid) &&
                    int.TryParse(tbpalveluntyyppi.Text, out tyyppi) &&
                    double.TryParse(tbpalvelunhinta.Text, out hinta) &&
                    double.TryParse(tbalv.Text, out alv))
                {
                    command.Parameters.AddWithValue("@palvelu_id", palveluid);
                    command.Parameters.AddWithValue("@alue_id", alueid);
                    command.Parameters.AddWithValue("@nimi", tbpalvelunnimi.Text);
                    command.Parameters.AddWithValue("@tyyppi", tyyppi);
                    command.Parameters.AddWithValue("@kuvaus", tbpalvelunkuvaus.Text);
                    command.Parameters.AddWithValue("@hinta", hinta);
                    command.Parameters.AddWithValue("@alv", alv);
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Palvelu lisätty");

                }
                else
                {
                    MessageBox.Show("Väärät syötteet");
                    tbpalveluid.Clear();
                    tbalueid.Clear();
                    tbpalvelunnimi.Clear();
                    tbpalveluntyyppi.Clear();
                    tbpalvelunkuvaus.Clear();
                    tbpalvelunhinta.Clear();
                    tbalv.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Palvelun lisäys epäonnistui");
            }
        }

    }
}
