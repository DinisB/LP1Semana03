using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("");
            string str = Console.ReadLine();
            Console.Write("");
            char.TryParse(Console.ReadLine(), out char charater);
            str = str.Replace(charater, 'x');
            Console.WriteLine(str);
        }
    }
}
