using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotekarz
{
    public partial class nowaksiazka : Form
    {
        public nowaksiazka()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();


        }

        private void nowaksiazka_Load(object sender, EventArgs e)
        {



        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void identyfikatorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int liczba_ksiazek = 1;


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
                    label1.Text = "Connection Error";
                }

                command.Connection = connection;
                command.CommandText = "Select * From Books";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        liczba_ksiazek++;

                    }
                }

                command.Connection = connection;
                command.CommandText = "Insert INTO Books (Id, Title, Author) VALUES(" + liczba_ksiazek + ", '" + txtTitle.Text + "','" + txtAuthor.Text + "');";

                using (DbDataReader dataReader2 = command.ExecuteReader())
                {

                }


                txtApprove.Text = txtTitle.Text + " znajduje się w bazie";

        }


    }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
