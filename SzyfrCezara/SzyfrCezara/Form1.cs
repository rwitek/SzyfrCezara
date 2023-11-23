using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzyfrCezara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SzyfrujButton_Click(object sender, EventArgs e)
        {
            string tekst = TekstTextBox.Text;
            int klucz = int.Parse(KluczTextBox.Text);

            string zaszyfrowanyTekst = szyfrCezara(tekst, klucz);

            ZaszyfrowanyTekst.Text = "Zaszyfrowany tekst: " + zaszyfrowanyTekst;
            OryginalnyTekst.Text = "Oryginalny tekst: " + tekst;

        }

      private static string szyfrCezara(string tekst, int klucz)
        {
            const string alfabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
            const string alfabet2 = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPQRSŚTUVWXYZŹŻ";
            char[] znaki = tekst.ToCharArray();

            for (int i = 0; i < znaki.Length; i++)
            {
                if (char.IsUpper(znaki[i]))
                {
                    int pozycja = alfabet2.IndexOf(znaki[i]);
                    if (pozycja != -1)
                    {

                        int nowaPozycja = (pozycja + klucz) % alfabet2.Length;
                        znaki[i] = alfabet2[nowaPozycja];
                    }
                }
                else
                {
                    int pozycja = alfabet.IndexOf(znaki[i]);
                    if (pozycja != -1)
                    {

                        int nowaPozycja = (pozycja + klucz) % alfabet.Length;
                        znaki[i] = alfabet[nowaPozycja];
                    }
                }

            }
            return new string(znaki);

        }

       
    }
}
