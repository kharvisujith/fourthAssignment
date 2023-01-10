using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourthAssignment
{
    public  class StringClass
    {
        public void PrintMethod()
        {
            Console.WriteLine("This is from class Demo printMethod");
        }
    }

    public static class ExtensionClass
    {
        public static string ToCurrency(this StringClass obj,string inputString)
        {
            try
            {
                int isNumber = Convert.ToInt32(inputString);
                string outputString = "$" + isNumber;
                return outputString;
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }

        public static string StringContainsNumber(this StringClass obj, string inputString)
        {
           /* bool isIntString = inputString.Any(char.IsDigit);
            if (isIntString) return "$" + inputString;
            throw new FormatException("Input string format is Invalid");*/

            bool isInt = inputString.All(char.IsDigit);
            if (isInt) return "$" + inputString;
            throw new FormatException("Input string format is Invalid");

        }
    }
}
