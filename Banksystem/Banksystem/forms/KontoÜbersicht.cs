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
            filldgv();
        }

        private void filldgv()
        {
            dgv_transactions.Rows.Clear();

            DataTable transactions = Databank.SQLSelect("Select Accounts.Name, Transactions.Amount, Transactions.Date, Transactions.subtraction from transactions, Accounts where Transactions.FromID = Accounts.ID and Transactions.ToID = " + userdata.ID.ToString()+";");
            foreach (DataRow transaction in transactions.Rows)
            {
                dgv_transactions.Rows.Add(transaction[0], transaction[1]+"€", transaction[2]);
                if (bool.Parse(transaction[3].ToString()))
                {
                    dgv_transactions.Rows[dgv_transactions.Rows.Count-2].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.Red};
                }
                else
                {
                    dgv_transactions.Rows[dgv_transactions.Rows.Count - 2].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.Green };
                }
            }
        }


        private void KontoÜbersicht_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
