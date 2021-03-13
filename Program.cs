using System;

namespace GitExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Asigne un valor a la variable A");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Asigne un valor a la variable B");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"La operacion  de {a} - {b} es: {AddNumbers(a,b)}") ;
        }

        public static int AddNumbers(int a, int b)
        {
            return a - b;
        }
    }
}
