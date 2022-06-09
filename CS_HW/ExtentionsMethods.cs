using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW
{
    public static class ExtentionsMethods
    {
        /// <summary>
    /// Returns strings with upper first letter
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
        public static string FirstCharToUpper(this string x)
        {
            char[] stringChars = x.ToCharArray();
            if (Char.IsLower(stringChars[0]))
            {
                stringChars[0] = Char.ToUpper(stringChars[0]);
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (stringChars[i] == ' ')
                    stringChars[i + 1] = Char.ToUpper(stringChars[i + 1]);
            }
            return new string(stringChars);

        }
        /// <summary>
        /// Returns string while its chars changed upper to lower and revers
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string ReverseCase(this string x)
        {
            char[] stringChars = x.ToCharArray();
            for (int i = 0; i < x.Length; i++)
            {
                if (Char.IsUpper(stringChars[i]))
                {
                    stringChars[i] = Char.ToLower(stringChars[i]);
                }
                else if (Char.IsLower(stringChars[i]))
                {
                    stringChars[i] = Char.ToUpper(stringChars[i]);
                }
            }
            return new string(stringChars);
        }
        /// <summary>
        /// Returns strings with lower first letter
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string FirstCharToLower(this string x)
        {
            char[] stringChars = x.ToCharArray();
            for (int i = 1; i < x.Length; i++)
            {
                stringChars[i] = Char.ToUpper(stringChars[i]);
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (stringChars[i] == ' ')
                {
                    stringChars[i + 1] = Char.ToLower(stringChars[i + 1]);

                }
            }
            return new string(stringChars);

        }
        /// <summary>
        /// Returns strings with all lower letters 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string AllWordLower(this string x)
        {
            char[] stringChars = x.ToCharArray();
            for (int i = 0; i < x.Length; i++)
            {
                stringChars[i] = Char.ToLower(stringChars[i]);
            }
            return new string(stringChars);
        }
        /// <summary>
        /// Returns strings with zigzag upper-lower letters
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string OneUpOneLowCharString(this string x)
        {
            char[] stringChars = x.ToCharArray();
            for (int i = 1; i < x.Length; i++)
            {
                if (i % 2 == 0)
                {
                    stringChars[i] = Char.ToUpper(stringChars[i]);
                }
                else
                {
                    stringChars[i] = Char.ToLower(stringChars[i]);
                }


            }
            stringChars[0] = Char.ToUpper(stringChars[0]);
            for (int i = 0; i < x.Length; i++)
            {
                if (stringChars[i] == ' ')
                {
                    stringChars[i + 1] = Char.ToUpper(stringChars[i + 1]);

                }
            }
            return new string(stringChars);
        }
        /// <summary>
        /// Return reverse numbers string with its original string at the end
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string ReverseNumberStrAndItself(this string x)
        {
            char[] newNumbersChar = new char[x.Length];
            char[] numbersStr = x.ToCharArray();

            for (int i = 0; i < x.Length; i++)
            {
                newNumbersChar[i] = numbersStr[x.Length - i - 1];
            }
            char[] newSumNumbersStr = new char[x.Length * 2];

            char[] end = new char[x.Length * 2];
            for (int i = 0; i < x.Length * 2; i++)
            {
                if (i <= x.Length - 1)
                    end[i] = newNumbersChar[i];
                if (i > x.Length - 1)
                    end[i] = numbersStr[(x.Length - i) * -1];
            }
            return new string(end);
        }
        /// <summary>
        /// Get number list and write if can be sorted by as consecutive numbers
        /// </summary>
        /// <param name="numbersList"></param>
        public static void WriteIfnNumbersStrListAreConsecutive(List<int> numbersList)
        {

            numbersList.Sort();
            var x = numbersList.Distinct().ToList();
            if (numbersList.Count == x.Count)
            {
                int c = 0;
                Console.WriteLine("same count");
                for (int i = 0; i < x.Count(); i++)
                {
                    for (int j = 0; j < x.Count(); j++)
                    {
                        if (x[i] == x[j] + 1)
                            c++;
                    }
                }
                if (c == numbersList.Count - 1)
                {
                    Console.WriteLine("consecutive");
                }
                else
                {
                    Console.WriteLine("not consecutive");
                }
            }
            else
                Console.WriteLine("not same count");

        }
        /// <summary>
        /// Get 2 numbers and pow and write the count how much can be powered at the range 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static void PowerRanger()
        {
            Console.WriteLine("Enter number a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter pow n");
            double n = int.Parse(Console.ReadLine());


            List<double> allTheNumbersIn = new List<double>();
            double a2 = Math.Pow(a, (1.0 / n));

            double z = 0;
            while (z <= b)
            {
                z = Math.Pow(a2, n);
                if (z <= b)
                {
                    allTheNumbersIn.Add(z);
                }
                a2++;
            }
            Console.WriteLine($"Numbers can be powered: {allTheNumbersIn.Count}");

        }

      

    }

}
