using System;

namespace CS_HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //strings
            string firstLetterUpper = "happy birthday";
            string allWordUpper  = "MANY THANKS MOSHE";
            string zigzagUpperLower = "sPoNtAnEoUs";

            Console.WriteLine(firstLetterUpper.FirstCharToUpper());
            Console.WriteLine(firstLetterUpper.FirstCharToLower());
            Console.WriteLine(allWordUpper.AllWordLower());
            Console.WriteLine(zigzagUpperLower.OneUpOneLowCharString());

            //numbers as string
            Console.WriteLine("123".ReverseNumberStrAndItself());
            Console.WriteLine("152".ReverseNumberStrAndItself());
            Console.WriteLine("123456789".ReverseNumberStrAndItself());
            Console.WriteLine(zigzagUpperLower.ReverseCase());

            List<int> x = new List<int>() { 2,4,6,8 };
            
            ExtentionsMethods.WriteIfnNumbersStrListAreConsecutive(x);
            ExtentionsMethods.PowerRanger();







        }



    }

}
