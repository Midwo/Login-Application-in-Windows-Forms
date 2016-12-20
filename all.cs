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
    public partial class all : Form
    {
        public all()
        {
            InitializeComponent();
        }

        private void all_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu1 m = new Menu1();
            m.Show();
        }

        private void all_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agent2214_db1portfolioDataSet.Login_info' table. You can move, or remove it, as needed.
            this.login_infoTableAdapter.Fill(this.agent2214_db1portfolioDataSet.Login_info);

        }
    }
}
