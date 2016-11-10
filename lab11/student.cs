using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class student:person
    {

        private string program;

        private int year;

        private double fee;


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
                return program;
            }

            set
            {
                program = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }
        public override string ToString()
        {
            return $"student[{base.ToString()},program{Program},year{Year},fee{Fee}]";
        }
       
    }
}
