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
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Witaj: " + Uzytkownik_zalogowany.zalogowany +", data logowania: " + Uzytkownik_zalogowany.czas_zalogowania;
        }
    }
}
