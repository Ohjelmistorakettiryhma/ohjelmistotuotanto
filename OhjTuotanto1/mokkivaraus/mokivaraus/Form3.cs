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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mokivaraus
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button_muokkaa_nayta_Click(object sender, EventArgs e) //form3 muokkaa -nappi
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");

            string query = "SELECT * FROM lasku";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_muokkaa_laskutus.DataSource = table;
        }

        private void btn_muokkaa_muokkaa_Click(object sender, EventArgs e) // muokkaa -välilehden muokkaa -nappi
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");


            try
            {
                decimal summa = decimal.Parse(tbsumma_muokkaa.Text);
                decimal alv = decimal.Parse(tbalv_muokkaa.Text);

                decimal summaMiinusAlv = summa / (1 + alv / 100);

                connection.Open();

                MySqlCommand command = new MySqlCommand("UPDATE lasku SET varaus_id = @varaus_id, summa = @summa, alv = @alv WHERE lasku_id = @lasku_id", connection);

                command.Parameters.AddWithValue("@lasku_id", int.Parse(tbLaskuid_Muokkaa.Text)); ;
                command.Parameters.AddWithValue("@varaus_id", int.Parse(tbVarausid_muokkaa.Text)); ;
                command.Parameters.AddWithValue("@summa", summaMiinusAlv);
                command.Parameters.AddWithValue("@alv", alv);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    string query = "SELECT * FROM lasku";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView_muokkaa_laskutus.DataSource = table;

                    MessageBox.Show("Muokkaaminen onnistui!");
                }
                else
                {
                    MessageBox.Show("Muokkaaminen epäonnistui. Laskua ei löytynyt tietokannasta.");
                    tbLaskuid_Muokkaa.Clear();
                    tbVarausid_muokkaa.Clear();
                    tbsumma_muokkaa.Clear();
                    tbalv_muokkaa.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }

        private void tbLaskuid_Muokkaa_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tbLaskuid_Muokkaa.TextLength >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }



        }

        private void tbVarausid_muokkaa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tbVarausid_muokkaa.TextLength >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void tbsumma_muokkaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar) && !(char.IsDigit(e.KeyChar) || e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == ',')
            {
                if (e.KeyChar != (char)Keys.Back && tbsumma_muokkaa.Text.Contains(",") || tbsumma_muokkaa.TextLength == 0 || tbsumma_muokkaa.SelectionStart == 0)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar != (char)Keys.Back && tbsumma_muokkaa.Text.Contains(",") && tbsumma_muokkaa.Text.Substring(tbsumma_muokkaa.Text.IndexOf(",")).Length > 2 && tbsumma_muokkaa.SelectionStart > tbsumma_muokkaa.Text.IndexOf(","))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar != (char)Keys.Back && !tbsumma_muokkaa.Text.Contains(",") && tbsumma_muokkaa.TextLength >= 8)
            {
                e.Handled = true;
                return;
            }

        }

        private void tbalv_muokkaa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar) && !(char.IsDigit(e.KeyChar) || e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == ',')
            {
                if (e.KeyChar != (char)Keys.Back && tbalv_muokkaa.Text.Contains(",") || tbalv_muokkaa.TextLength == 0 || tbalv_muokkaa.SelectionStart == 0)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar != (char)Keys.Back && tbalv_muokkaa.Text.Contains(",") && tbalv_muokkaa.Text.Substring(tbalv_muokkaa.Text.IndexOf(",")).Length > 2 && tbalv_muokkaa.SelectionStart > tbalv_muokkaa.Text.IndexOf(","))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar != (char)Keys.Back && !tbalv_muokkaa.Text.Contains(",") && tbalv_muokkaa.TextLength >= 8)
            {
                e.Handled = true;
                return;
            }


        }

        private void tbLaskuid_Muokkaa_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
