using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    internal class FizzBuzzTasks
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Пример работы первой задачи:");
            
            FirstProcedure();
            
            Console.WriteLine("Пример работы второй задачи:");
            
            SecondProcedure();
            
            Console.WriteLine("Пример работы третьей задачи:");
            
            ThreeProcedure();
            
            
            
        }

        public static void FirstProcedure()
        {
            var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17};

            var result = numbers.Select(n =>
            {
                if (n % 3 == 0 && n % 5 == 0)
                    return "fizz-buzz";
                if (n % 3 == 0)
                    return "fizz";
                if (n % 5 == 0)
                    return "buzz";
                return n.ToString();
            }).ToList();
          
            Console.WriteLine(string.Join(", ", result));
        }


        public static void SecondProcedure()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };

            var  result = numbers.Select(n =>
            {
                string output = "";

                if (n % 3 == 0)
                    output += "fizz";
                if (n % 4 == 0)
                    output += "muzz";
                if (n % 5 == 0)
                    output += "buzz";
                if (n % 7 == 0)
                    output += "guzz";

                return !string.IsNullOrEmpty(output) ? output : n.ToString();
            }).ToList();

            Console.WriteLine(string.Join(", ", result));
        }


        public static void ThreeProcedure()
        {
            var  numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };

            var  result = numbers.Select(n =>
            {
                string output = "";

                if (n % 3 == 0)
                    output += "dog";
                if (n % 4 == 0)
                    output += "muzz";
                if (n % 5 == 0)
                    output += "cat";
                if (n % 7 == 0)
                    output += "guzz";

                if (n % 3 == 0 && n % 5 == 0)
                    output = "good-boy";

                return !string.IsNullOrEmpty(output) ? output : n.ToString();
            }).ToList();

            Console.WriteLine(string.Join(", ", result));
            
        }
    }
}