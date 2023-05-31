using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    public class AccountEventArgs
    {
        private string _message = "Empty";
        private decimal _sum = 0;

        public string Message
        {
            get;
            set; 
        }

        public decimal Sum
        {
            get 
            { 
                return _sum; 
            }
            private set => _sum = value;
        }


        public AccountEventArgs(string message, decimal sum)
        {
            Sum = sum;
            Message = message;
        }
    }
}
