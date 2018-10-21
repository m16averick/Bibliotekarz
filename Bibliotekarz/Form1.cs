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


        private void bDodawanie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '+';
            tbInfo.Text = "";
        }
        private void bOdejmowanie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '-';
            tbInfo.Text = "";
        }

        private void bDzielenie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '/';
            tbInfo.Text = "";
        }

        private void bMnożenie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '*';
            tbInfo.Text = "";
        }


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


        private void b1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }
        //niżej jest b5 o.0
        private void b5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }


        private void b7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
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
