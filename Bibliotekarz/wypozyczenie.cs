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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet11.Readers' . Możesz go przenieść lub usunąć.
            this.readersTableAdapter1.Fill(this.libraryDataSet11.Readers);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //            int liczba_ksiazek = 1;


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
                        //liczba_ksiazek++;

                    }
                }

                command.Connection = connection;
                command.CommandText = "Update Books SET Lender = 2 Where Id = 4";

                using (DbDataReader dataReader2 = command.ExecuteReader())
                {

                }


                txtApprove.Text = " znajduje się w bazie";

            }


        }
                   
        private void button1_Click_1(object sender, EventArgs e)
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


                string termin = DateTime.Now.AddDays(14).ToShortDateString();
                command.Connection = connection;
                command.CommandText = "Update Books SET Lender=" + Int32.Parse(txtIdR.Text) + ", Termin='" + termin + "' Where Id=" + Int32.Parse(txtIdB.Text);
                //               command.CommandText = "Update Books SET Lender=" + Int32.Parse(txtIdR.Text) + "Where Id=" + Int32.Parse(txtIdB.Text);

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        //label1.Text += $"{dataReader["Id"]} " + $"{dataReader["title"]} ";

                    }
                }

                command.CommandText = "Select * From Readers Where Id="+Int32.Parse(txtIdR.Text);
                

                using (DbDataReader dataReader2 = command.ExecuteReader())
                {
                    while (dataReader2.Read())
                    {
                        txtApprove.Text = $"{dataReader2["Name"]} " + $"{dataReader2["Surname"]} ";

                    }
                }

            


            txtApprove.Text += "Wypożycza ";

            command.CommandText = "Select * From Books Where Id=" + Int32.Parse(txtIdB.Text);


            using (DbDataReader dataReader3 = command.ExecuteReader())
            {
                while (dataReader3.Read())
                {
                    txtApprove.Text += $"{dataReader3["Title"]} " /* + $"{dataReader3["Author"]} "*/ ;

                }
            }

                txtApprove.Text += " Termin: " + termin;
        }

    }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = booksDataGridView.Rows[e.RowIndex].Cells[0].Value;
            if (value is DBNull) { return; }

            string IdKsiazki = value.ToString();
            txtIdB.Text = IdKsiazki;
        }

        private void readersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = booksDataGridView.Rows[e.RowIndex].Cells[0].Value;
            if (value is DBNull) { return; }

            string IdCzytelnika = value.ToString();
            txtIdR.Text = IdCzytelnika;
        }
    }
}
