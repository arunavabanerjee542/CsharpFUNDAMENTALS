using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals
{

    //  USED SWITCH STATEMENTS TO CATEGORIZE EMPLOYEE LEVEL

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> e = new List<Employee>()
            {
                new Employee( 33333, "Arunava"),
                new Employee(29000, "Ravi"),
            new Employee(10000, "Raj")
            };


            foreach(Employee emp in e )
            {
                Console.WriteLine(emp.name + " Belongs to level " + getlevel(emp.sal));

            }

        }



        public static string getlevel(int sal)
        {
            switch(sal)
            {
                case var x when x > 30000:
                    return "L1";

                case var x when x > 25000:
                    return "L2";

                case var x when x > 15000:
                    return "L3";

                default:
                    return " FIRED ";


            }


        }







    }

    class Employee
    {
      
       public string name;
       public int sal;
        

      public  Employee(int n , string s)
        {
            this.name = s;
            this.sal = n;
        }

    }


}
