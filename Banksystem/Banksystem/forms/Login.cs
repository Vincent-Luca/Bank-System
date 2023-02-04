using Banksystem.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Banksystem
{
    public partial class Login : Form
    {
        private readonly DBConnection _Databank;
        public DBConnection Databank => _Databank;

        private userdata userdata;
        public Login()
        {
            InitializeComponent();
            _Databank = new DBConnection("Data Source=localhost;Initial Catalog=Bank;Persist Security Info=True;User ID=sa;Password=supersecretpassword");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pin.Text) || string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Nicht alle felder sind ausgefüllt");
                return;
            }

            encryption encryption = new encryption();
            string encryptedpin = encryption.encrypt(txt_pin.Text);

            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>() {{"@name", txt_username.Text }, {"@pin", encryptedpin } };
            if (!Databank.isAvailable("Select * from Accounts where Name = @name and Pin = @pin", dict))
            {
                MessageBox.Show("No account with the Given Username and Pin were found, please double check Spelling and try again");
                return;
            }
            InsertData(Databank.SQLSelect("Select * from Accounts where Name = @name and Pin = @pin", dict));

            this.Hide();
            KontoÜbersicht k = new KontoÜbersicht(userdata, Databank);
            k.ShowDialog();
            this.Show();
        }

        private void InsertData(DataTable data)
        {
            foreach (DataRow item in data.Rows)
            {
                userdata = new userdata(int.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), DateTime.Parse(item[3].ToString()), int.Parse(item[4].ToString()), item[5].ToString());
            }
            return;
        }

        private void btn_newaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewAccount a = new NewAccount(Databank);
            a.ShowDialog();
            this.Show();
        }

        private void rb_rememberme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_showpin_Click(object sender, EventArgs e)
        {
            txt_pin.UseSystemPasswordChar = !txt_pin.UseSystemPasswordChar;
        }
    }
}
