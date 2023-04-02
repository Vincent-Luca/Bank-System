using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banksystem.classes.dataClasses;
namespace Banksystem.forms
{
    public partial class Accounts : Form
    {
        private readonly AccountsData data;
        public Accounts(AccountsData data)
        {
            InitializeComponent();
            this.data = data;
            setData();
        }


        private void setData()
        {
            lbl_iban.Text = data.IBAN;
            lbl_name.Text = data.name;
            lbl_total.Text = data.Total.ToString();
            if (data.Total.ToString()[0] == '-')
            {
                lbl_total.ForeColor = Color.Red;
            }
            else
            {
                lbl_total.ForeColor = Color.Green;
            }
        }

        private void btn_details_Click(object sender, EventArgs e)
        {

        }
    }
}
