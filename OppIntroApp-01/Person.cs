using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppIntroApp_01
{
    class Person
    {

        public String firstName;
        public String middleName;
        public String lastName;

        public string GetFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverse = String.Empty;
            for(int i = cArray.Length-1; i >- 1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }
        
}
