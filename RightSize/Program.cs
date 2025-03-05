using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (var arg in args){
                if (arg.Length > 3) {
                    Console.WriteLine(arg);
                }
                else if (arg.Length >= 8) {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
            }
        }
    }
}
