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

        public userdata(int ID, string Name, string Pin, DateTime CreationDate)
        {
            this.ID = ID;
            this.Name = Name;
            this.Pin = Pin;
            this.CreationDate = CreationDate;
        }
    }
}
