using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class person
    {
        private string name;
        private string address;

        public string Name
        {
            get
            {
                return name;
            }

          
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        public person(string nam, string addres)
        {
            name = nam;
            address = addres;
            
        }
        public override string ToString()
        {
            return $"person[name{Name},address{Address}]";
        }
    }
}
