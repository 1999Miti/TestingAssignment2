using System;

namespace UnitTest_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "Miti";
            string num = "1999";
            if (num.IsValidNumeric() == true)
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            else
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            if (num.ConvertStringToNumber() == null)
                Console.WriteLine("\"" + num + "\" can not convert in numeric value");
            else
                Console.WriteLine("\"" + num + "\" numeric value is : " + num.ConvertStringToNumber());
            Console.WriteLine("Input : \"" + input + "\" into Uppercase Letter : " + input.ConvertToUpper());
            input = "MITI";
            Console.WriteLine("Input : \"" + input + "\" into Lowercase Letter : " + input.ConvertToLower());
            input = "miti nayak";
            Console.WriteLine("Input : \"" + input + "\" into Titlecase Letter : " + input.ConvertToTitleCase());
            input = "miti";
            Console.WriteLine("Check all the character of string is lower case or not : \"" + input + "\" : " + input.IsLower());
            input = "miti nayak";
            Console.WriteLine("Input : \"" + input + "\" into Capitalize : " + input.ConvertToCapitalize());
            input = "MITI";
            Console.WriteLine("Is input in uppercase : \"" + input + "\" : " + input.IsUpper());
            input = "miti nayak";
            Console.WriteLine("No of words in the input : \"" + input + "\" : " + input.CountingWord());
            input = "Miti";
            Console.WriteLine("Removing last character from input : \"" + input + "\" : "+ input.RemoveLastCharacterFrom());            
            
        }
    }
}
