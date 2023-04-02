using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem.classes.dataClasses
{
    public class AccountsData
    {
        public readonly int KID;
        public readonly int AccID;
        public readonly DateTime CreationDate;
        public readonly int Total;
        public readonly string IBAN;
        public readonly string name;
        public readonly bool main;

        public AccountsData(int KID, int AccID,DateTime CreationDate ,int Total, string IBAN, string name, bool main)
        {
            this.KID = KID;
            this.AccID = AccID;
            this.CreationDate = CreationDate;
            this.Total = Total;
            this.IBAN = IBAN;
            this.name = name;
            this.main = main;
        }
    }
}
