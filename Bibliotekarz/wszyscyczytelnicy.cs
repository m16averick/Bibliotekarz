﻿using System;
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
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void wszyscyczytelnicy_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet1.Readers' . Możesz go przenieść lub usunąć.
            this.readersTableAdapter1.Fill(this.libraryDataSet1.Readers);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet1.Books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter1.Fill(this.libraryDataSet1.Books);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet.Books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'libraryDataSet.Readers' . Możesz go przenieść lub usunąć.
            this.readersTableAdapter.Fill(this.libraryDataSet.Readers);

        }

        private void readersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }
    }
}
