using System;

namespace Repa_bm
{
    class MainClass
    {
        public static Random rand = new Random();
        public static void Main(string[] args)
        {
            Repa uj = new Repa();
            Console.WriteLine(uj.Informacio());
            Repa ujabb = new Repa("sárgarépa");
            Console.WriteLine(ujabb.Informacio());
            //Console.WriteLine($"{uj.Kor} év, {uj.Minoseg}% minősségű, ");
            while (ujabb.Tick(rand.NextDouble() * (0.2 - 0.05) + 0.05)) //ujabb.Minoseg > 0 && ujabb.Kor <= 7
            {
                //Console.WriteLine($"Kezdete {ujabb.Informacio()}");
                Console.WriteLine($"{ujabb.Informacio()}\n");
            }
        }
    }
}
