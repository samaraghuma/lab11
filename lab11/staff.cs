using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class staff : person
        

    {
        private string school;

        private double pay;


        public staff(string name, string adress, string school, double pay) : base(name, adress)
        {
            this.School = school;
            this.Pay = pay;


        }
        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }
        public double Pay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }
        public override string ToString()
        {
            return $"student[{base.ToString()}],school{School},pay{pay}]";
        }
    }
}
