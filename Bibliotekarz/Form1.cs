﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;


namespace Bibliotekarz
{


    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }


        private void tbInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWypozyczenie_Click(object sender, EventArgs e)
        {
            //this.Hide();
            wypozyczenie wypozyczenie = new wypozyczenie();
            wypozyczenie.ShowDialog();
            //this.Close();
        }



        private void btnZwrot_Click(object sender, EventArgs e)
        {

            zwrot zwrot = new zwrot();
            zwrot.ShowDialog();
        }

        private void btnNowaKsiazka_Click(object sender, EventArgs e)
        {

            nowaksiazka nowaksiazka = new nowaksiazka();
            nowaksiazka.ShowDialog();
        }

        private void btnNowyCzytelnik_Click(object sender, EventArgs e)
        {
            nowyczytelnik nowyczytelnik = new nowyczytelnik();
            nowyczytelnik.ShowDialog();
        }



        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();


        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet.Books' . Możesz go przenieść lub usunąć.
            int liczba_ksiazek = 0;
            int liczba_wypozyczonych_ksiazek = 0;
            int zaleglosci = 0;

            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    tbInfo.Text = "Connection Error";
                }

                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    tbInfo.Text = "Command Error";
                }

                command.Connection = connection;
                command.CommandText = "Select * From Books";

                string termin;
                string now = DateTime.Now.AddDays(14).ToShortDateString();
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        liczba_ksiazek++;
                        termin = $"{dataReader["termin"]}";
                        if ($"{dataReader["lender"]} " != " ")
                        {
                            liczba_wypozyczonych_ksiazek++;
                            if (DateTime.Parse(termin) < DateTime.Now) zaleglosci++;
                        }


                        tbInfo.Text += $"{dataReader["Id"]} " + $"{dataReader["title"]} " + Environment.NewLine;

                    }
                }

            }

            tbInfo.Text += "Biblioteka jest obecnie w posiadaniu " + liczba_ksiazek + " książek z czego " + liczba_wypozyczonych_ksiazek + " znajduje sie w wypozyczeniu oraz " + zaleglosci + " leży zaległych u czytelników.";


        }

        private void btnWszystkieKsiazki_Click(object sender, EventArgs e)
        {
            wszystkieksiazki wszystkieksiazki = new wszystkieksiazki();
            wszystkieksiazki.ShowDialog();

        }

        private void btnWszyscyCzytelnicy_Click(object sender, EventArgs e)
        {
            wszyscyczytelnicy wszyscyczytelnicy = new wszyscyczytelnicy();
            wszyscyczytelnicy.ShowDialog();
        }

        private void btnZaleglosci_Click(object sender, EventArgs e)
        {
            zaleglosci zaleglosci = new zaleglosci();
            zaleglosci.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            tbInfo.Text = "";
            Form1_Load(this, e);
        }
    }
}
