﻿using System;
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
    public partial class wypozyczenie : Form
    {
        public wypozyczenie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    label1.Text = "Connection Error";
                }

                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    label1.Text = "Command Error";
                }

                command.Connection = connection;
                command.CommandText = "Select * From Books";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        label1.Text += $"{dataReader["Id"]} " + $"{dataReader["title"]} ";

                    }
                }
                //label1.Text = textBox1.Text;

            }







            
        }

        private void booksBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void wypozyczenie_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet1.Readers' . Możesz go przenieść lub usunąć.
            this.readersTableAdapter.Fill(this.libraryDataSet1.Readers);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet1.Books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter1.Fill(this.libraryDataSet1.Books);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet.Readers' . Możesz go przenieść lub usunąć.
            this.readersTableAdapter.Fill(this.libraryDataSet.Readers);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet.Books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter1.Fill(this.libraryDataSet.Books);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet.Readers' . Możesz go przenieść lub usunąć.
            this.readersTableAdapter.Fill(this.libraryDataSet.Readers);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet.Books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter1.Fill(this.libraryDataSet.Books);
            Fillcombo();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.booksTableAdapter.FillBy(this.bazaaaDataSet.books);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        void Fillcombo()
        {
/*
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    //tbInfo.Text = "Connection Error";
                }

                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    //tbInfo.Text = "Command Error";
                }

                command.Connection = connection;
                command.CommandText = "Select * From Books";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        //tbInfo.Text += $"{dataReader["Id"]} " + $"{dataReader["title"]} " + Environment.NewLine;

                        comboBox1.Items.Add($"{dataReader["title"]} ");

                    }
                }

            }
            */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.booksTableAdapter1.FillBy(this.libraryDataSet.Books);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}