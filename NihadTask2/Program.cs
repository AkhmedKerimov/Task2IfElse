using System;

namespace NihadTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tapşırıqlar
            1) 1 - dən M - ədək ədədlər içərisində 21 - ə bölünən ədədlərin ədədi ortasını tapan alqoritm

            2) 2 ədəd verilmişdir. Daxil Edilən Ədədlərdə Daxil Olmaqla Bu Ədədlərin Aralığında Olan Ədədlərin cəmin Tapan Alqoritm Qurun.

            3) Verilmiş M-dən N - ədək ədədlər içərisində neçə ədədin rəqəmləri cəminin cüt olduğunu tapan alqoritm*/

            #region Tapsirig-1

            Console.WriteLine("m ucun bir deyer gir: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int count = 0;

            for (int i = 1; i < m; i++)
            {
                if (i%21==0)
                {
                    sum += i;
                    count++;
                }
            }
            int edediOrta = sum / count;
            Console.WriteLine(edediOrta);
            #endregion

            #region Tapsirig-2
            Console.WriteLine("Birinci ededi gir: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ikinci ededi gir: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum2 = 0;
            for (int i = a; i <= b; i++)
            {
                sum2 += i;
            }
            Console.WriteLine(sum2);
            #endregion
        }
    }
}
