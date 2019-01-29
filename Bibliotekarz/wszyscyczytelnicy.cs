using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotekarz
{
    public partial class wszyscyczytelnicy : Form
    {
        public wszyscyczytelnicy()
        {
            InitializeComponent();
        }

        private void readersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet2);

        }

        private void wszyscyczytelnicy_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet2.Books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter.Fill(this.libraryDataSet2.Books);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet2.Readers' . Możesz go przenieść lub usunąć.
            this.readersTableAdapter.Fill(this.libraryDataSet2.Readers);

        }
    }
}
