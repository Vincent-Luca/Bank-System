using Banksystem.classes.dataClasses;
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
    public partial class Transactions : Form
    {
        private readonly DBConnection Databank;
        private readonly userdata userdata;
        private List<AccountsData> Accounts = new List<AccountsData>();
        public Transactions(DBConnection Databank, userdata userdata)
        {
            InitializeComponent();
            this.Databank = Databank;
            this.userdata = userdata;

            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>
            {
                {"@AccID", userdata.ID}
            };
            LoadAcc(Databank.SQLSelect("Select * from Konto where AccID = @AccID", data));
            combo_Accounts.SelectedIndex = 0;
        }

        private void LoadAcc(DataTable data)
        {
            foreach (DataRow Row in data.Rows)
            {
                combo_Accounts.Items.Add(Row[5].ToString());


                AccountsData Temp = new AccountsData(Convert.ToInt32(Row[0]), Convert.ToInt32(Row[1]), Convert.ToDateTime(Row[2]), Convert.ToInt32(Row[3]), Row[4].ToString(), Row[5].ToString(), Convert.ToBoolean(Row[6].ToString()));
                Accounts.Add(Temp);
            }
        }

        private void combo_Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_YIBAN.Text = Accounts[combo_Accounts.SelectedIndex].IBAN;
        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {

        }
    }
}
