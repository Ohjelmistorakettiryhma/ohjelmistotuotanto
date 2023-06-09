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
    public partial class AlueenlisaysForm : Form
    {
        public AlueenlisaysForm()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=vn;uid=root;pwd=Ruutti;");
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            string query = "INSERT INTO alue (alue_id, nimi) VALUES (@alue_id, @nimi)";
            MySqlCommand command = new MySqlCommand(query, connection);

            int alueid;
            string nimi;

            if (int.TryParse(tbalueid.Text, out alueid))
            {

                command.Parameters.AddWithValue("@alue_id", alueid);
                command.Parameters.AddWithValue("@nimi", tbalueennimi.Text);

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Alue lisätty");

            }
            else
            {
                MessageBox.Show("Väärät syötteet");
                tbalueid.Clear();
                tbalueennimi.Clear();
            }
        }
    }
}
