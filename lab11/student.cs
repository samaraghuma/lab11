using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class student:person
    {
        public student(string name, string address, string program, int year, double fee) : base(name, address)

        {
           this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }



        public string Program
        {
            get
            {
                return Program;
            }

            set
            {
                Program = value;
            }
        }

        public int Year
        {
            get
            {
                return Year;
            }

            set
            {
                Year = value;
            }
        }

        public double Fee
        {
            get
            {
                return Fee;
            }

            set
            {
                Fee = value;
            }
        }
        public override string ToString()
        {
            return $"student[{base.ToString()},program{Program},year{Year},fee{Fee}]";
        }
       
    }
}
