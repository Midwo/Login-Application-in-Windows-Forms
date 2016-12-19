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
    }
}
