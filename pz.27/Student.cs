using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace pz._27
{
    public struct STUDENT
    {
        private string NAME = "test";
        private string GROUP = "test";
        private byte[] SES = new byte[5];

        private void fillSES()
        {
            var rnd = new Random();
            for (int iii = 0; iii < SES.Length; ++iii)
            {
                SES[iii] = Convert.ToByte(rnd.Next(2, 6));
            }
        }

        public STUDENT()
        {
            fillSES();
        }

        public STUDENT(string name, string group)
        {
            NAME = name;
            GROUP = group;
            fillSES();
        }

        public string Name { get => NAME; set => NAME = Name; }
        public string Group { get => GROUP; set => GROUP = Group; }
    }
}
