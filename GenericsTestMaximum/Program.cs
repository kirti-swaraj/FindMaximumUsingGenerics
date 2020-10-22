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
            /// UC 5 : Prints out the max value given any number of values
          
            int[] arr1 = { 12, 45, 67, 234, 67 };
            GenericMaximum<int> generic1 = new GenericMaximum<int>(arr1);
            generic1.PrintMaxValue();
            string[] arr2 = { "Ram", "Shyam", "Geeta", "Aseem" };
            GenericMaximum<string> generic2 = new GenericMaximum<string>(arr2);
            generic2.PrintMaxValue();
        }
    }
}
