using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    public struct Account
    {
        private int Id;
        private string AccountHolder;
        private double Balance;

        public Account(int id, string holder, double bal)
        {
            Id = id; AccountHolder = holder; Balance = bal;
        }
        public int AccId
        {
            get { return Id; }
            set { Id = value; }
        }
        public string AccHolder
        {
            get { return AccountHolder; }
            set { AccountHolder = value; }
        }
        public double AccBalance
        {
            get { return Balance; }
            set { Balance = value; }
        }

        public override string ToString()
        {
            return $"AccountId: {AccId}, AccountHolder: {AccHolder}, Balance: {AccBalance}";
        }
    }
}
