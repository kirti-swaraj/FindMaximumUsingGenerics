// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindMaximum.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace GenericsTestMaximum
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class FindMaximum
    {
        /// <summary>
        /// UC 1 : Find the Maximum integer among three.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        public static int MaxIntegerAmongThree(int firstValue, int secondValue, int thirdValue)
        {
            Console.WriteLine("Maximum number among {0}, {1} and {2}: ", firstValue, secondValue, thirdValue);
            /// Checks if firstValue is greater than both secondValue and thirdValue
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            /// Checks if secondValue is greater than both firstValue and thirdValue
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            else
                return thirdValue;
        }
    }
}
