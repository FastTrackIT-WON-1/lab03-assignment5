using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = ReadString("Enter value (attempt 1)=")
                            ?? ReadString("Enter value (attempt 2)=")
                            ?? ReadString("Enter value (attempt 3)=")
                            ?? "nu am continut";

            Console.WriteLine(value);
        }

        private static string ReadString(string label)
        {
            Console.Write(label);
            string value = Console.ReadLine();

            return string.IsNullOrWhiteSpace(value) ? null : value;
        }
    }
}
