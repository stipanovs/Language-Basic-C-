using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasic
{
    class Program
    {
        class Book
        {
            public string name;
            public string author;
            public int year;
            public static int Num = 0;

            public static void PrintNum()
            {
                Console.WriteLine(Num);
            }

            
        }

        public struct Vector
        {
            public int X;
            public int Y;
        }

        //passing arguments by value
        static string Concatenate(string str1, string str2)
        {
            return str1 + " " + str2;
        }

        // passing arguments by reference
        static void ConcatenateRef(ref string str1, ref string str2)
        {
            str1 = str1 + ", Sergiu";
            str2 = str2 + "!!!!!";
        }

        static void CreateVector(out Vector v1, out Vector v2)
        {
            v1.X = 14;
            v1.Y = 24;
            v2.X = 0;
            v2.Y = 5 * 2;
        }

        
        static void Main(string[] args)
        {
            // Create a helLo world program in C#
            Console.WriteLine("Hello, World!");
            

            // Create instances of value types and reference types
            // value types

            int a = 5;
            char c = 'g';
            bool yes = true;
            Vector vector = new Vector() { X = 2, Y = 5 };

            // reference types

            string str = "Good";
            Book book1 = new Book();
            book1.name = "Amintiri din copilarie";
            book1.author = "I. Creanga";
            book1.year = 2003;
           
            // Use static methods


            // Write a method for each type of parameter modifier
            // by value
            string str1 = "Hello";
            string str2 = ", World!";
            string str3 = Concatenate(str1, str2);

            // by reference, ref modifier
            ConcatenateRef(ref str1, ref str2);
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            // by reference, out modifier

            Vector v1 = new Vector(){ X = 4, Y = 10 };
            Vector v2; 
            CreateVector(out v1, out v2);
            Console.WriteLine(v1.X + " " + v1.Y);
            Console.WriteLine(v2.X + " " + v2.Y);

            // Use boxing and unboxing to prove the understanding of it
            // boxing
            int b = 5;
            object obj = b;

            // unboxing

            int b1 = (int)obj;

            double d = 2.3456;
            int dInt = (int)d;


            Console.ReadLine();
        }
    }
}
