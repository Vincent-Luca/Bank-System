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
        public readonly int ID;
        public readonly string Name;
        public readonly string Pin;
        public readonly DateTime CreationDate;
        public readonly bool BusinessAccount;

        public userdata(int ID, string Name, string Pin, DateTime CreationDate, bool businessAccount)
        {
            this.ID = ID;
            this.Name = Name;
            this.Pin = Pin;
            this.CreationDate = CreationDate;
            BusinessAccount = businessAccount;
        }
    }
}
