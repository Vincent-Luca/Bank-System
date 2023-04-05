using Banksystem.classes.dataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banksystem.forms
{
    public partial class KontoUebersicht : Form
    {
        private readonly userdata userdata;
        private readonly DBConnection Databank;
        private bool saveexit = false;

        public KontoUebersicht(userdata userdata, DBConnection Databank)
        {
            InitializeComponent();
            this.userdata = userdata;
            this.Databank = Databank;

            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>
            {
                {"@AccID", userdata.ID}
            };

            LoadAllKonto(Databank.SQLSelect("Select * from Konto where AccID = @AccID",data));
        }

        private void KontoÜbersicht_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saveexit)
                Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveexit = true;
            this.Close();
        }

        private void LoadAllKonto(DataTable data)
        {
            int i = 0;

            foreach (DataRow Row in data.Rows)
            {

                Panel panel = new Panel();
                pan_Accounts.Controls.Add(panel);
                panel.Size = new Size(776, 100);
                panel.Location = new Point(0,i*100);
                panel.Name = "panel"+i.ToString();
                panel.BorderStyle = BorderStyle.FixedSingle;

                Accounts Temp = new Accounts(new AccountsData(Convert.ToInt32(Row[0]), Convert.ToInt32(Row[1]), Convert.ToDateTime(Row[2]), Convert.ToInt32(Row[3]), Row[4].ToString(), Row[5].ToString(), Convert.ToBoolean(Row[6].ToString()))) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel.Controls.Add(Temp);
                pan_Accounts.Controls.Add(panel);
                Temp.Show();
                i++;
            }
        }

        private void btn_newacc_Click(object sender, EventArgs e)
        {
            if (pan_newAccount.Visible)
            {
                return;
            }
            pan_newAccount.Visible = true;
        }

        private string createIBAN(encryption encript)
        {
            return "EUCBS" + encript.encrypt(userdata.Name) + userdata.Pin + encript.encrypt(txt_AccName.Text);
        }

        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_AccName.Text))
            {
                MessageBox.Show("Account must have a name");
                return;
            }

            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            data.Clear();
            data.Add("@kid", int.Parse(Databank.SQLSelect("Select TOP(1) KID from Konto order by KID desc;").Rows[0][0].ToString()) + 1);
            data.Add("@accid", userdata.ID);
            data.Add("@creationdate", DateTime.Parse(DateTime.Now.ToShortDateString()));
            data.Add("@total", 0);
            data.Add("@iban", createIBAN(new encryption()));
            data.Add("@name", txt_AccName.Text);
            data.Add("@main", false);
            Databank.executenonquery("Insert into Konto(KID,AccID,CreationDate,Total,IBAN,Name,Main) Values(@kid,@accid,@creationdate,@total,@iban,@name,@main)", data);

            pan_Accounts.Controls.Clear();
            data.Clear();
            data.Add("@AccID", userdata.ID);
            LoadAllKonto(Databank.SQLSelect("Select * from Konto where AccID = @AccID", data));
            txt_AccName.Text = "";
            pan_newAccount.Visible = false;
        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {
            Transactions trans = new Transactions(Databank, userdata);
            trans.ShowDialog();
        }
    }
}
