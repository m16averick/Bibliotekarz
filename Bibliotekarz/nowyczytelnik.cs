using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotekarz
{
    public partial class nowyczytelnik : Form
    {
        public nowyczytelnik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int liczba_czytelnikow = 1;


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
                command.CommandText = "Select * From Readers";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        liczba_czytelnikow++;

                    }
                }

                command.Connection = connection;
                command.CommandText = "Insert INTO Readers (Id, Name, Surname, City, Postcode, Street, Number, Apartament) VALUES(" + liczba_czytelnikow + ", '" + txtName.Text + "','" + txtSurname.Text + "','" + txtCity.Text + "','" + txtPostcode.Text + "','" + txtStreet.Text + "','" + txtNumber.Text + "','" + txtApartament.Text + "');";

                using (DbDataReader dataReader2 = command.ExecuteReader())
                {

                }


                txtApprove.Text = txtName.Text + " " + txtSurname.Text + " znajduje się w bazie";

            }
        }
    }
}
