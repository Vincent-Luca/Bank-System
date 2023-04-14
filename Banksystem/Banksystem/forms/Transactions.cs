using Banksystem.classes.dataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>
            {
                {"@IBAN",txt_Riban.Text }
            };

            if (!IsNumeric(txt_Amount.Text))
            {
                MessageBox.Show("Please only put numbers in the Amount textbox");
            }

            if (!Databank.isAvailable("Select * from Konto where IBAN = @IBAN;",data))
            {
                MessageBox.Show("No Account exists with that IBAN, please Check your spelling");
                return;
            }

            int ToKID = Convert.ToInt32(Databank.SQLSelect("Select KID from Konto where IBAN = @IBAN;",data).Rows[0][0]);

            data.Clear();
            data.Add("@amount", Convert.ToDouble(txt_Amount.Text));
            data.Add("@KID", ToKID);
            // Add to the ToKID
            Databank.executenonquery("UPDATE Konto Set Total = total + @amount where KID=@KID", data);
            //Subtracts from the FromKID
            data.Remove("@KID");
            data.Add("@KID", Accounts[combo_Accounts.SelectedIndex].KID);
            Databank.executenonquery("UPDATE Konto Set Total = total - @amount where KID=@KID", data);
            //makes a new insert into the transaction table
            data.Clear();
            data.Add("@TransID", Convert.ToDouble(txt_Amount.Text));
            data.Add("@FromKID", Accounts[combo_Accounts.SelectedIndex].KID);
            data.Add("@ToKID", ToKID);
            data.Add("@Amount", Convert.ToDouble(txt_Amount.Text));
            data.Add("@Date", DateTime.Parse(DateTime.Now.ToShortDateString()));
            data.Add("@Comment",  string.IsNullOrEmpty(txt_Comment.Text) ? null : txt_Comment.Text);
            Databank.executenonquery("Insert into Transactions(TransID, FromKID, ToKID, Amount, Date, Comment) values(@TransID, @FromKID, @ToKID, @Amount, @Date, @Comment)", data);
            MessageBox.Show("Transaction Succsesfull!");
            this.Close();
        }

        private bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }
    }
}
