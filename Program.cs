using System.Globalization;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace C__Adv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Non_Generic Collections - Arraylist



            // ArrayList Numbers = new ArrayList(10) { 1, 2, 3, 4, 5 };
            //
            // //for ( int i = 0; i < Numbers.Count; i++ )
            // //{
            // //    Console.WriteLine(Numbers[i]);
            // //}
            //
            // //Numbers.GetEsureCapactiy(21);
            // if (Numbers.Capacity < 21)
            //     Numbers.Capacity = 21;
            //
            //
            //  // for (int i = 6; i < 21; i++)
            //   {
            //       Numbers.Add(i);
            //   }
            //  //
            // //Cons of Non-Genric collections
            // // 1. Boxing
            // // 2. Casting from object [refrence type ] to int object type // unboxing [unsafe casting]
            // 
            //
            //
            //
            //
            // Console.WriteLine($"Count = {Numbers.Count}, Capacity = { Numbers.Capacity}");
            //
            // Numbers.Add(1);
            // Numbers.Add(2);
            // Numbers.AddRange(new int[] {3,4});
            //
            // 
            //
            // Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");
            //
            // Numbers.Add(5);
            //
            // Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");
            //
            // Numbers.TrimToSize();   // Free | Size | Relsease | DealLocate Unused Bytes = 12 Bytes.
            //
            // Console.WriteLine(" ------ After Trimng -------");
            //
            //
            // Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");
            //
            //
            //
            //


            #endregion

            #region Generic Collections - List

         //   public static int SumOfList(List<int> Numbers)
         //    {
         //   int sum = 0;
         //   if (Numbers?.Count > 0) 
         //   {
         //       if (int i = 0; int <Numbers.Count ; i++)
         //       Sum += Numbers[i]
         //   }
         //   return sum;           
         //    }


           // ArrayList Numbers = new ArrayList(10) { 1, 2, 3, 4, 5 };
           //
           //
           // List<int> NUmbers = new List<int>();
           //
          //int result = SumOfList
          //     Console.WriteLine(result);


           // Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");
           //
           // NUmbers.Add( 1 );
           // Numbers.Add( 2 );
           // Numbers.AddRange([3 , 4]);
           //
           // Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");
           //
           // Numbers.Add(5);
           //
           // Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");
           //
           // Numbers.TrimExcess();  // Free | Deallocate | Delete | Release Unused Bytes = 12 Bytes
           //
           // Console.WriteLine(" ----- After Triming -------");
           //
           // Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");

            #endregion

        }
    }
}
