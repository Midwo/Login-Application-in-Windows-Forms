using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            string a1 = tb1.Text;
            string b1 = mtb1.Text;
            typ_generyczny_podmiana.podmianka<string>(ref a1, ref b1);
            string haslo = Zmiana_hasla.zmiana_hasla_na_prawdziwe(a1, b1);
            DataSet tabela = new DataSet();
            tabela = zapytanie.select("Select Czas, GETDATE() From MD_Magazyn_Call_Center Where Login ='" + tb1.Text + "' and Haslo = '" + haslo + "'", "MD_Magazyn_Call_Center");

            if (tabela.Tables[0].Rows.Count <= 0)
            {

                MessageBox.Show("Błedny login lub hasło!");

            }
            else
            {
                string datalicencji = tabela.Tables[0].Rows[0][0].ToString();
                string dataobecnabazy = tabela.Tables[0].Rows[0][1].ToString();
                DateTime datalicencji1 = DateTime.Parse(datalicencji);
                DateTime dataobecnabazy1 = DateTime.Parse(dataobecnabazy);
                if (datalicencji1 > dataobecnabazy1)
                {

                    Uzytkownik_zalogowany.zalogowany = tb1.Text;
                    Uzytkownik_zalogowany.czas_zalogowania = DateTime.Now.ToString();
                    MessageBox.Show("Data ważności licencji: " + datalicencji1.ToShortDateString() + "", "MD - Licencja informacja");
                    Menu1 fk = new Menu1();
                    fk.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Licencja wygasła dnia: " + datalicencji1.ToShortDateString() + "", "MD - Licencja informacja");
                    Application.Exit();
                }
            }
        }
    }
}
