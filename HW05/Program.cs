using System;

namespace HW05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] LED = new string[] { "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", };
            string[] nameLED = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", };
            Console.WriteLine(string.Join(" ", LED));
            Console.WriteLine(string.Join("  ", nameLED));
            Console.WriteLine("Please choose LED to turn On/Off:");
            int count = 1;
            while (count <= 100)
            {
                string number = Console.ReadLine();
                
                for (int i = 0; i < nameLED.Length; i++)
                {
                    if (nameLED[i] == number & LED[i] == "[]")
                    {
                        LED[i] = "[!]";
                    }
                    else if (nameLED[i] == number & LED[i] == "[!]")
                    {
                        LED[i] = "[]";
                    }
                }
                Console.WriteLine(string.Join(" ", LED));
                Console.WriteLine(string.Join("  ", nameLED));
                Console.WriteLine("Please choose LED to turn On/Off:");
            }
        }
    }
}
