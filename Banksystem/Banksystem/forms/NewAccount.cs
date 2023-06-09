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
    public partial class NewAccount : Form
    {
        private readonly DBConnection Databank;
        public NewAccount(DBConnection Databank)
        {
            InitializeComponent();
            this.Databank = Databank;
        }

        private void btn_createnewaccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pin.Text)|| string.IsNullOrEmpty(txt_confirmpin.Text) || string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("All Text fields must be filled out");
                return;
            }

            if (Databank.isAvailable("Select AccID from Account where Name = '"+ txt_username.Text + "';"))
            {
                MessageBox.Show("Username already taken, please choose something else or a variation of your Name");
                return;
            }

            encryption encript = new encryption();

            int id = int.Parse(Databank.SQLSelect("Select TOP(1) AccID from Account order by AccID desc;").Rows[0][0].ToString()) + 1;
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>()
            {
                {"@ID",id},
                {"@Name",txt_username.Text },
                {"@Pin", encript.encrypt(txt_pin.Text) },
                {"@CreationDate",DateTime.Parse(DateTime.Now.ToShortDateString()) },
                {"@BusinessAccount",chb_BusinessAccount.Checked }
            };
            Databank.executenonquery("Insert into Account(AccID,Name,Pin,CreationDate,BusinessAccount) values(@ID,@Name,@Pin,@CreationDate,@BusinessAccount);", data);

            int kid = int.Parse(Databank.SQLSelect("Select TOP(1) KID from Konto order by KID desc;").Rows[0][0].ToString()) + 1;
            data.Clear();
            data.Add("@kid",kid);
            data.Add("@accid",id);
            data.Add("@creationdate",DateTime.Parse(DateTime.Now.ToShortDateString()));
            data.Add("@total",500);
            data.Add("@iban", createIBAN(encript));
            data.Add("@name","Main");
            data.Add("@main",true);
            Databank.executenonquery("Insert into Konto(KID,AccID,CreationDate,Total,IBAN,Name,Main) Values(@kid,@accid,@creationdate,@total,@iban,@name,@main)",data);


            id = int.Parse(Databank.SQLSelect("Select TOP(1) TransID from Transactions order by TransID desc;").Rows[0][0].ToString()) + 1;
            data.Clear();
            data.Add("@ID", id);
            data.Add("@FromID", "1");
            data.Add("@ToID", kid);
            data.Add("@Amount", 500);
            data.Add("@Date", DateTime.Parse(DateTime.Now.ToShortDateString()));
            data.Add("@Comment", "Thank you for signing up to the Europen Union Central Banking System");
            Databank.executenonquery("Insert into Transactions(TransID,FromKID,ToKID,Amount,Date,Comment) Values(@ID,@FromID,@ToID,@Amount,@Date,@Comment);",data);

            MessageBox.Show("Account successfully created");
            this.Close();
        }

        

        private string createIBAN(encryption encript)
        {
            return "EUCBS"+encript.encrypt(txt_username.Text) + encript.encrypt(txt_pin.Text) + encript.encrypt("Main");
        }

        public string createBID()
        {
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_pin.UseSystemPasswordChar = !txt_pin.UseSystemPasswordChar;
            txt_confirmpin.UseSystemPasswordChar = !txt_confirmpin.UseSystemPasswordChar;
        }
    }
}
