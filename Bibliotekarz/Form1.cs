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
        }

        private void btnNowaKsiazka_Click(object sender, EventArgs e)
        {

        }

        private void btnNowyCzytelnik_Click(object sender, EventArgs e)
        {

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }





    }
}
