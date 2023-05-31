using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz._28
{
    public delegate void DelegateEventHandler(object sender, ACEventArgs e);

    public class ACEventArgs
    {
        string _message = "";
        int _value = 0;

        public string Message { get { return _message; } set { _message = value; } }
        public int Value { get { return _value; } set { _value = value; } }

        public ACEventArgs(string message, int value)
        {
            _message = message;
            _value = value;
        }
    }
}
