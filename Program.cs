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

            #region Generic Colloections _ List ( Methods )

            //
            //    List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //
            //    Numbers.Insert(0, 100);
            //    Numbers.InsertRange(1, [101, 102, 102, 103, 104, 105]);
            //
            //    foreach (int i in Numbers)
            //    {
            //        Console.WriteLine(Numbers);
            //    }
            //
            //    IReadOnlyList<int> ReadOnlyNumbers = Numbers.AsReadOnly();
            //
            //    Numbers.AddRange([4, 6, 7, 8, 9]);
            //
            //    foreach (int i in ReadOnlyNumbers)
            //    {
            //        Console.WriteLine(Numbers);
            //    }
            //
            //
            //  //  int index = Numbers.BinarySearch(100); // -101
            //
            //   // Console.WriteLine($" INdex = {index}");
            //
            //    List<Employee> Employees = new List<Employee>();
            //
            //    {
            //        new Employee(10, "Ahmed", 4000);
            //        new Employee(20, "Bassem", 5000);
            //        new Employee(30, "Osama", 6000);
            //    }
            //
            //    Employees.Sort();
            //
            // //   int index = Employees.BinarySearch(new Employee(20, "Bassem", 5000));
            // //   index = Employees.BinarySearch(new Employee() { Name = " Bassem" }, new EmployeeComaprer);
            // //   index = Employees.BinarySearch(1, 2,new Employee() { Name = " Bassem" }, new EmployeeComaprer);
            //
            //    Console.WriteLine(Employees);
            //    
            //    
            //    Numbers.Clear();
            //
            //    Numbers.Contains(10);
            //
            //    //    Numbers.ConvertAll<long>(SomeFunctions.Tesat);
            //    //
            //    //    class Somefunctions
            //    //{ 
            //    //
            //    //}
            //    int[] Arr = new int[11];
            //
            //    Numbers.CopyTo(Arr ,5  );
            //
            //    foreach (int number in Arr)
            //        Console.WriteLine(number);
            //
            //    Numbers.EnsureCapacity(10);
            //
            //    int evenNumbers = Numbers.FindLast((N) => N % 2 == 0);
            //
            //    int index = Numbers.FindLastIndex (N => N % 2 == 0);
            //
            //    int[] evenNumber = Numbers.FindAll ( N => N % 2 == 0 ).ToArray();
            //
            //    Console.WriteLine($"Even Nubmer = {evenNumbers} Exsited at index : {index}");
            //
            //
            //
            //    Numbers.Exists(Hamda => Hamda % 2 == 0);
            //    Console.Write(isExist);
            //
            //
            //    Numbers.TrueForAll((N) => N % 2 == 0);
            //
            //    Numbers.ForEach(N =>
            //    {
            //        N += 100;
            //    });
            //
            //
            //    Numbers.IndexOf(5 , 2 , 3);
            //
            //    Numbers.RemoveAll(N => N % 2 == 1);
            //
            //    Numbers.Reverse();
            //

            #endregion


            #region Generic Collections - LinkedList

            //  LinkedList<int> Numbers = new LinkedList<int>();
            //
            //
            //  LinkedList<int> FirstNode = Numbers.AddFirst(1);
            //  LinkedList<int> FourNode = Numbers.AddLast(3);
            //
            //  LinkedListNode<int> SecondNode = Numbers.AddAfter(FirstNode , 2);
            //
            //  LinkedList<int> ThirdNode = Numbers.AddBefore(FourthNode , 3);
            //
            //  Console.WriteLine(FirstNode.previous.Value); // 2
            #endregion

            #region GenericUriParser Collections _ Stack

            Stack<int> stack = new Stack<int> ();

            stack.Push (1);
            stack.Push (2);
            stack.Push (3);
            stack.Push (4);
            Console.WriteLine(stack.TryPop(out int Values01)); // 4
            Console.WriteLine(stack.TryPop(out int Values02));  // 3 
            Console.WriteLine(stack.TryPop(out int Values03)); // 2
            Console.WriteLine(stack.TryPop(out int Values04));  // 1


            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Pop());

            Console.WriteLine("__________________");

            //foreach (int number in stack )
            //Console. writeline(number);


            #endregion

            #region  Generic Collections - Queue

            Queue<int> queue = new Queue<int> ();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Dequeue()); // 1
            Console.WriteLine(queue.Dequeue()); // 2
            Console.WriteLine(queue.TryDequeue(out int Value03)); // 3


            Console.WriteLine("***************");


            foreach(int i in queue) 
            
        Console.WriteLine(i);


            #endregion
        }
    }
}
