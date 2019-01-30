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
    public partial class zwrot : Form
    {
        public zwrot()
        {
            InitializeComponent();
        }

        private void txtIdB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdB.Text.Length == 0 || txtIdR.Text.Length == 0) { }
            else
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
                    command.CommandText = "Update Books SET Lender=NULL, Termin=NULL Where Id=" + Int32.Parse(txtIdB.Text);

                    using (DbDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            //label1.Text += $"{dataReader["Id"]} " + $"{dataReader["title"]} ";

                        }
                    }

                    command.CommandText = "Select * From Readers Where Id=" + Int32.Parse(txtIdR.Text);


                    using (DbDataReader dataReader2 = command.ExecuteReader())
                    {
                        while (dataReader2.Read())
                        {
                            txtApprove.Text = $"{dataReader2["Name"]} " + $"{dataReader2["Surname"]} ";

                        }
                    }




                    txtApprove.Text += "Zwraca ";

                    command.CommandText = "Select * From Books Where Id=" + Int32.Parse(txtIdB.Text);


                    using (DbDataReader dataReader3 = command.ExecuteReader())
                    {
                        while (dataReader3.Read())
                        {
                            txtApprove.Text += $"{dataReader3["Title"]} " /* + $"{dataReader3["Author"]} "*/ ;

                        }
                    }

                }

                zwrot_Load(this, e);
            }
        }

        private void txtIdR_TextChanged(object sender, EventArgs e)
        {

        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void zwrot_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet.Readers' . Możesz go przenieść lub usunąć.
            this.readersTableAdapter.Fill(this.libraryDataSet.Readers);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet.Readers' . Możesz go przenieść lub usunąć.
            this.readersTableAdapter.Fill(this.libraryDataSet.Readers);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet.Books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter.FillBy1(this.libraryDataSet.Books);

        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = booksDataGridView.Rows[e.RowIndex].Cells[0].Value;
            if (value is DBNull) { return; }

            object value2 = booksDataGridView.Rows[e.RowIndex].Cells[3].Value;
            if (value is DBNull) { return; }

            string IdKsiazki = value.ToString();
            string IdCzytelnika = value2.ToString();
            txtIdB.Text = IdKsiazki;
            txtIdR.Text = IdCzytelnika;
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.booksTableAdapter.FillBy1(this.libraryDataSet.Books);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
