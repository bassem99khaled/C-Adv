using System.Globalization;
using System.Collections;

namespace C__Adv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Non_Generic Collections - Arraylist



            ArrayList Numbers = new ArrayList(10) { 1, 2, 3, 4, 5 };

            //for ( int i = 0; i < Numbers.Count; i++ )
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Numbers.GetEsureCapactiy(21);
            if (Numbers.Capacity < 21)
                Numbers.Capacity = 21;


            for (int i = 6; i < 21; i++)
            {
                Numbers.Add(i);
            }




            Console.WriteLine($"Count = {Numbers.Count}, Capacity = { Numbers.Capacity}");

            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.AddRange(new int[] {3,4});

            

            Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");

            Numbers.Add(5);

            Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");

            Numbers.TrimToSize();   // Free | Size | Relsease | DealLocate Unused Bytes = 12 Bytes.

            Console.WriteLine(" ------ After Trimng -------");


            Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");


            

            #endregion



        }
    }
}
