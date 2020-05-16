using System;
using System.Runtime.CompilerServices;
using System.IO;
namespace StringManipulation
{
    class Program
    {
        public static string ReplaceSpaceToUnderScore()
        {
            Console.Write("Enter the String message: ");
            string str1 = Convert.ToString(Console.ReadLine());
            // Replace all spaces with underscores on the user input string.
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == ' ')

                   str1 = str1.Replace(" ", "_");
            }            
            return str1;
        }

        public static string RemoveLeadingSpace()
        {
            Console.Write("Enter the String message have leading space: ");
            string str1 = Convert.ToString(Console.ReadLine());
            // Removes Leading space on the user input string.
            Console.WriteLine("<<<" + str1+ ">>>");
            string str2 = str1.TrimStart();
            Console.Write("Output:");
            str2 = ("<<<" + str2 + ">>>");

           return str2;
        }

        public static string RemoveTrailingSpace()
        {
            Console.Write("Enter the String message have Trailing space: ");
            string str1 = Convert.ToString(Console.ReadLine());
            // Removes trailing space on the user input string.
            Console.WriteLine("<<<" + str1 + ">>>");
            string str2 = str1.TrimEnd();
            Console.Write("Output:");
            str2 = ("<<<" + str2 + ">>>");

            return str2;
        }

        public static string ReplaceLowercaseAbyUppercaseA()
        {
            char ch1, ch2;
            string str2 = "";
            Console.Write("Enter the String message have Lowercase A: ");
            string str1 = Convert.ToString(Console.ReadLine());
            // Replace Lowercase A by Uppercase A on the user input string.
            
            for (int i = 0; i < str1.Length; i++)
            {
                ch1 = str1[i];
                if (ch1 == 'a')
                {
                  ch2 = Char.ToUpper(ch1);
                  str2 = str2.ToString() + ch2.ToString();
                }
               else
                   str2 = str2.ToString() + ch1.ToString();
            }

            return str2;
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("\n//Replace all spaces with underscores on the user input string//\n");
            Console.WriteLine(ReplaceSpaceToUnderScore());

            Console.WriteLine("\n//Removes leading space on the user input string//\n");
            Console.WriteLine(RemoveLeadingSpace());

            Console.WriteLine("\n//Removes trailing space on the user input string//\n");
            Console.WriteLine(RemoveTrailingSpace());

            Console.WriteLine("\n//Replace lowercase A by uppercase A on the user input string//\n");
            Console.WriteLine(ReplaceLowercaseAbyUppercaseA());

            Console.WriteLine("\nEnter any key to Quit!");
            Console.ReadLine();

        }
    }
}
