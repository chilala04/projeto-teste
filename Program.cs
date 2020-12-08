using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with number of matriz: ");
            int n = int.Parse(Console.ReadLine());
            int vl = (n < 10) ? n * 2 : n + 10;

            Console.WriteLine(vl);

        }
    }
}
