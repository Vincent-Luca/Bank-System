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

        public userdata(int ID, string Name, string Pin, DateTime CreationDate)
        {
            this.ID = ID;
            this.Name = Name;
            this.Pin = Pin;
            this.CreationDate = CreationDate;
        }
    }
}
