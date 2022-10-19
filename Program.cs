using System;

namespace Klase_i_objekti_2
{
    class KlasaC
    {
        public int zbroj(int[] niz);






    }
    class Program
    {
        static void Main(string[] args)
        {
            KlasaC klasaC = new KlasaC();
            int[] brojevi = new int[5];
            Console.WriteLine("Upiši 5 cijelih brojeva: ");
            for (int i = 0; i < 5; i++)
            {
                brojevi[i] = Convert.ToInt32(Console.Readline());
                
            }

        }

    }
    
}
