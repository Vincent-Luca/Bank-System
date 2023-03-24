using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banksystem.forms
{
    public partial class KontoÜbersicht : Form
    {
        private userdata userdata;
        private DBConnection Databank;

        public KontoÜbersicht(userdata userdata, DBConnection Databank)
        {
            InitializeComponent();
            this.userdata = userdata;
            this.Databank = Databank;
        }

        private void KontoÜbersicht_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
