using System;
using System.Linq;

namespace TDDWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            var cowSay = new CowSay();
            while (true)
            {
                var cow = cowSay.CreateCow(input);

                foreach (var line in cow.Result)
                {
                    Console.WriteLine(line);
                }

                input = Console.ReadLine();
            }
        }
    }
}
