using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem.classes.dataClasses
{
    public class TransactionData
    {
        public readonly int TransID;
        public readonly int FromKID;
        public readonly int ToKID;
        public readonly int Amount;
        public readonly DateTime Date;
        public readonly string Comment;

        public TransactionData(int TransID,int FromKID,int ToKID,int Amount, DateTime Date, string Comment)
        {
            this.TransID = TransID;
            this.FromKID = FromKID;
            this.ToKID = ToKID;
            this.Amount = Amount;
            this.Date = Date;
            this.Comment = Comment;
        }
    }
}
