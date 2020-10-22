// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace GenericsTestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC 1 : Finds max among the given three data
            //Console.WriteLine(FindMaximum.MaxIntegerAmongThree(89, 12, 50));
            // UC 2 : Finds the max float value among three
            //Console.WriteLine(FindMaximum.MaxFloatAmongThree(6.986, 6.64, 6.948));
            // UC 3 : Finds the max string value among three
            //Console.WriteLine(FindMaximum.MaxStringAmongThree("Apple", "Banana", "Peach"));

            // UC 3: Refactor 1
            //Console.WriteLine(FindMaximum.MaxValueAmongThreeRefactor1<int>(13, 47, 66));
            //Console.WriteLine(FindMaximum.MaxValueAmongThreeRefactor1<double>(19.85, 178.856, 14.59));
            //Console.WriteLine(FindMaximum.MaxValueAmongThreeRefactor1<string>("Spring", "Sports", "Badminton"));

            // UC 3 : Refactor 2
            //GenericMaximum<int> maxInt = new GenericMaximum<int>(58, 96, 102);
            //GenericMaximum<double> maxFloat = new GenericMaximum<double>(27.59, 35.98, 12.877);
            //GenericMaximum<string> maxString = new GenericMaximum<string>("Kirti", "Pakhi", "Golu");
            //Console.WriteLine(maxInt.MaxMethod());
            //Console.WriteLine(maxFloat.MaxMethod());
            //Console.WriteLine(maxString.MaxMethod());

            /// UC 4: Find maxm among any value of int
            int[] arr1 = { 12, 45, 67, 234, 67 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr1);
            Console.WriteLine(generic.MaxMethod());

            /// UC 4: Find maxm among any value of string
            string[] arr2 = { "Ram", "Shyam", "Geeta", "Zebra" };
            GenericMaximum<string> gen = new GenericMaximum<string>(arr2);
            Console.WriteLine(gen.MaxMethod());
        }
    }
}
