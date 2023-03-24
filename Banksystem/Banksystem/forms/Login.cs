using Banksystem.forms;
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
using Banksystem;
using System.Xml.Linq;

namespace Banksystem
{
    public partial class Login : Form
    {
        private readonly DBConnection _Databank;
        public DBConnection Databank => _Databank;

        private userdata userdata;

        private rememberme setting = new rememberme();
        public Login()
        {
            InitializeComponent();
            _Databank = new DBConnection("Data Source=localhost;Initial Catalog=Bank;Persist Security Info=True;User ID=sa;Password=supersecretpassword");

            //if (setting.remember)
            //{
            //    txt_username.Text = setting.name;
            //    txt_pin.Text = setting.password;
            //    login();
            //}
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pin.Text) || string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Nicht alle felder sind ausgefüllt");
                return;
            }

            login();
        }

        private void login(bool rememberme = false)
        {
            encryption encryption = new encryption();
            string encryptedpin = encryption.encrypt(txt_pin.Text);

            //if (setting.remember)
            //{
            //    encryptedpin = setting.password;
            //}


            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>() { { "@name", txt_username.Text }, { "@pin", encryptedpin } };
            if (!Databank.isAvailable("Select * from Account where Name = @name and Pin = @pin", dict))
            {
                MessageBox.Show("No account with the Given Username and Pin were found, please double check Spelling and try again");
                return;
            }
            InsertData(Databank.SQLSelect("Select * from Account where Name = @name and Pin = @pin", dict));

            //if (rememberme)
            //{
            //    setting.name = txt_username.Text;
            //    setting.password = encryptedpin;
            //    setting.Save();
            //}

            this.Hide();
            KontoÜbersicht k = new KontoÜbersicht(userdata, Databank);
            k.ShowDialog();
            this.Show();
        }


        private void InsertData(DataTable data)
        {
            foreach (DataRow item in data.Rows)
            {
                userdata = new userdata(int.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), DateTime.Parse(item[3].ToString()));
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
            if (!rb_rememberme.Checked)
            {
                return;
            }
            if (string.IsNullOrEmpty(txt_pin.Text) || string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Nicht alle felder sind ausgefüllt");
                rb_rememberme.Checked = false;
                return;
            }
            setting.remember = true;
            
        }

        private void btn_showpin_Click(object sender, EventArgs e)
        {
            txt_pin.UseSystemPasswordChar = !txt_pin.UseSystemPasswordChar;
        }
    }
}
