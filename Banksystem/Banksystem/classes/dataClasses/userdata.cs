using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banksystem
{
    public class userdata
    {
        public int ID;
        public string Name;
        public string Pin;
        public DateTime CreationDate;
        public int Total;
        public string IBAN;

        public userdata(int ID, string Name, string Pin, DateTime CreationDate, int Total, string IBAN)
        {
            this.ID = ID;
            this.Name = Name;
            this.Pin = Pin;
            this.CreationDate = CreationDate;
            this.Total = Total;
            this.IBAN = IBAN;
        }
    }
}
