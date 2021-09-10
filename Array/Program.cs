using System;
using System.Collections.Generic;


namespace ArrayProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] language = {"Ruby", "C", "C++", "Java",
                             "Perl", "C#", "Python", "PHP"};

            Array.ForEach(language, item =>
            {
                Console.WriteLine(item);
            });

            Console.ReadLine();
        }

       
    }
}
