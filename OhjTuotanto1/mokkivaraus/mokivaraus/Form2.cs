using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace mokivaraus
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

         
            connection.Open();

            string query = "INSERT INTO mokki (mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara) VALUES (@mokki_id, @alue_id, @postinro, @mokkinimi, @katuosoite, @hinta, @kuvaus, @henkilomaara)";
            MySqlCommand command = new MySqlCommand(query, connection);

            int mokkiid, alueid, henkilomaara;
            decimal hinta;
            string postinro, mokkinimi, katuosoite, kuvaus;

            if (int.TryParse(tbmokkiid_mokki.Text, out mokkiid) &&
                int.TryParse(tbalueid_mokki.Text, out alueid) &&
                decimal.TryParse(tbhinta_mokki.Text, out hinta) &&
                int.TryParse(tbhenkilomaara_mokki.Text, out henkilomaara))
            {
                command.Parameters.AddWithValue("@mokki_id", mokkiid);
                command.Parameters.AddWithValue("@alue_id", alueid);
                command.Parameters.AddWithValue("@postinro", tbpostinumero_mokki.Text);
                command.Parameters.AddWithValue("@mokkinimi", tbmokkinimi_mokki.Text);
                command.Parameters.AddWithValue("@katuosoite", tbkatuosoite_mokki.Text);
                command.Parameters.AddWithValue("@hinta", hinta);
                command.Parameters.AddWithValue("@kuvaus", tbkuvaus_mokki.Text);
                command.Parameters.AddWithValue("@henkilomaara", henkilomaara);

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Mökki lisätty");
            }
            else
            {
                MessageBox.Show("Väärät syötteet");
                tbmokkiid_mokki.Clear();
                tbalueid_mokki.Clear();
                tbpostinumero_mokki.Clear();
                tbmokkinimi_mokki.Clear();
                tbkatuosoite_mokki.Clear();
                tbhinta_mokki.Clear();
                tbkuvaus_mokki.Clear();
                tbhenkilomaara_mokki.Clear();
            }




        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
