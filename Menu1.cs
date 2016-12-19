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
        Simple_select hmm = new Simple_select();
        DataSet table = new DataSet();
       
        public Menu1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Witaj: " + Uzytkownik_zalogowany.zalogowany +", data logowania: " + Uzytkownik_zalogowany.czas_zalogowania;
            table = hmm.select("SELECT TOP 10 Login, Date FROM Login_info Where login = '"+Uzytkownik_zalogowany.zalogowany+"' ORDER BY Date DESC", "Login_info");
            dataGridView1.DataSource = table.Tables[0];

        }

        private void Menu1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agent2214_db1portfolioDataSet.Login_info' table. You can move, or remove it, as needed.
            this.login_infoTableAdapter.Fill(this.agent2214_db1portfolioDataSet.Login_info);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            

        }

        private void pokażToolStripMenuItem_Click(object sender, EventArgs e)
        {
            all m = new all();
            m.Show();
            this.Hide();
        }

        private void Menu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
