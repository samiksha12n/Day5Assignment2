using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList StudentGrades = new ArrayList
            {
                85,92,78,95,88 
            };
            Console.WriteLine("Sum of Array Elemts:"+StudentGrades.Count);
            int res = 0;
            res= StudentGrades.Count;
            Console.WriteLine(res);
            foreach(int i in StudentGrades)
            {
                Console.WriteLine(i);
            }
            StudentGrades.Add(90);
            Console.WriteLine("Added the new Grade");
            foreach (int i in StudentGrades)
            {
                Console.WriteLine(i);
            }
            StudentGrades.RemoveAt(2);
            Console.WriteLine("After removing ");
            foreach (int i in StudentGrades)
            {
                Console.WriteLine(i);
            }





            Console.ReadKey();
        }
    }
}
