using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppIntroApp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person aPerson = new Person();
            aPerson.firstName = "Istiaq";
            aPerson.middleName = "Haider";
            aPerson.lastName = "Hridon";

            String fullName = aPerson.GetFullName();
            Console.WriteLine(fullName);


            String reverseName = aPerson.GetReverseName();
            Console.WriteLine(reverseName);

            Console.ReadLine();
        

         
        }
    }
}
