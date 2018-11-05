using MySql.Data.MySqlClient;
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


    public partial class Form1 : Form
    {



        public Form1()
        {
            
            InitializeComponent();
            


        }

        string LiczbaPierwsza, LiczbaDruga;
        char RodzajDzialania = ' ';




        private void bWynik_Click(object sender, EventArgs e)
        {
            switch (RodzajDzialania)
            {
                case ('+'):
                    tbInfo.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('-'):
                    tbInfo.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('*'):
                    tbInfo.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('/'):
                    tbInfo.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                    break;

            }
        }

        private void tbInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWypozyczenie_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
            //this.Hide();
            wypozyczenie wypozyczenie = new wypozyczenie();
            wypozyczenie.ShowDialog();
            //this.Close();
        }



        private void btnZwrot_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
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
        
        private void Dzialanie(int liczba)
        {
            if (RodzajDzialania == ' ')
            {
                LiczbaPierwsza += liczba;
                tbInfo.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                tbInfo.Text = LiczbaDruga;
            }
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaaaDataSet);

        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaaaDataSet.books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter.Fill(this.bazaaaDataSet.books);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaaaDataSet.books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter.Fill(this.bazaaaDataSet.books);

        }





    }
}
