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

        }
    }
}