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
            connection.Open();

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

        }
    } 


