using System.Collections;

namespace C__Adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Given an array  consists of  numbers with size N and number of queries,
            //in each query you will be given an integer X, and you should print
            //how many numbers in array that is greater than  X .
            //   Ex  :
            //       Input 3 3                
            // Size of array , number of querie
            // s 11 5 3             //Array   
            //  1                      //Query  1
            //  5                     //Query   2
            //  13                  //Query     3
            //  Output 3  11,5, 3        1 1   1 0






            //
            //  string[] input = Console.ReadLine().Split();
            //  int n = int.Parse(input[0]);
            //  int q = int.Parse(input[1]);
            //
            //  int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //
            //
            //  for (int i = 0; i < q; i++)
            //  {
            //      int x = int.Parse(Console.ReadLine());
            //      int count = 0;
            //
            //      foreach (int num in array)
            //      {
            //          if (num > x)
            //          {
            //              count++;
            //          }
            //      }     
            //     Console.WriteLine(count);
            //  }




            #endregion

            #region 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //    Ex:
            //   Input:   5
            //  1 3 2 3 1
            //  Output: YES


            //     int n = int.Parse(Console.ReadLine());
            //
            //
            //     int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //
            //
            //     bool isPalindrome = IsPalindrome(array);
            //
            //  
            //     Console.WriteLine(isPalindrome ? "YES" : "NO");
            // 
            //
            // static bool IsPalindrome(int[] array)
            // {
            //     int left = 0, right = array.Length - 1;
            //
            //     while (left < right)
            //     {
            //         if (array[left] != array[right])
            //         {
            //             return false;
            //         }
            //         left++;
            //         right--;
            //     }
            //
            //     return true;
            // }
            //



            #endregion

            #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.


            //    Queue<int> queue = new Queue<int>();
            //
            //    queue.Enqueue(1);
            //    queue.Enqueue(2);
            //    queue.Enqueue(3);
            //    queue.Enqueue(4);
            //
            //
            //    Console.WriteLine("Original Queue:");
            //
            //    ReverseQueueUsingStack(queue);
            //
            //    Console.WriteLine("Reversed Queue:");
            //   
            //
            //
            //
            //static void ReverseQueueUsingStack(Queue<int> queue)
            //{
            //    Stack<int> stack = new Stack<int>();
            //
            //    while (queue.Count > 0)
            //    {
            //        stack.Push(queue.Dequeue());
            //    }
            //
            //   
            //    while (stack.Count > 0)
            //    {
            //        queue.Enqueue(stack.Pop());
            //    }
            //}
            //
            //
            //static void PrintQueue(Queue<int> queue)
            //{
            //    foreach (int item in queue)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            //  Ex:
            //  Input:   [()] { }
            //  Output:  Balanced




            //
            //     string input = Console.ReadLine();
            //
            //     if (IsBalanced(input))
            //     {
            //         Console.WriteLine("Balanced");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Not Balanced");
            //     }
            // 
            //
            // static bool IsBalanced(string s)
            // {
            //     Stack<char> stack = new Stack<char>();
            //
            //     foreach (char ch in s)
            //     {
            //         
            //         if (ch == '(' || ch == '{' || ch == '[')
            //         {
            //             stack.Push(ch);
            //         }
            //      
            //         else if (ch == ')' || ch == '}' || ch == ']')
            //         {
            //             if (stack.Count == 0) return false; 
            //
            //             char top = stack.Pop();
            //             if (!IsMatching(top, ch)) return false;
            //         }
            //     }
            //
            //    
            //     return stack.Count == 0;
            // }
            //
            // static bool IsMatching(char open, char close)
            // {
            //     return (open == '(' && close == ')') ||
            //            (open == '{' && close == '}') ||
            //            (open == '[' && close == ']');
            // }




            #endregion

            #region 5. Given an array, implement a function to remove duplicate elements from an array



            //    
            // static int[] RemoveDuplicates(int[] array)
            // {
            //     HashSet<int> uniqueElements = new HashSet<int>(array);
            //     return new List<int>(uniqueElements).ToArray();
            // }
            // 
            // int[] array = { 1, 2, 2, 3, 4, 4, 5 };
            //
            //
            // int[] result = RemoveDuplicates(array);
            //
            //
            // Console.WriteLine(string.Join(" ", result));
            //


            #endregion

            #region 6. Given an array list , implement a function to remove all odd numbers from it.

            
      
            
         //   static void RemoveOdds(ArrayList list)
         //   {
         //       for (int i = list.Count - 1; i >= 0; i--)
         //       {
         //           if ((int)list[i] % 2 != 0) 
         //           {
         //               list.RemoveAt(i); 
         //           }
         //       }
         //   }
         //
         //   
         //   static void PrintArrayList(ArrayList list)
         //   {
         //       foreach (var item in list)
         //       {
         //           Console.Write(item + " ");
         //       }
         //       Console.WriteLine();
         //   }
         //
         //
         //  ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10 , 11 ,12};
         //
         //  Console.WriteLine("Original ArrayList:");
         //          PrintArrayList(numbers);
         //
         //
         //  RemoveOdds(numbers);
         //
         //  Console.WriteLine("Array after removing odd numbers:");
         //          PrintArrayList(numbers);
         //


        #endregion


    }
}
}
