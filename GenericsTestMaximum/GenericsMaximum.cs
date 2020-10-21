using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum
{
    public class GenericMaximum<T> where T : IComparable
    {
        T firstValue, secondValue, thirdValue;
        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        /// <summary>
        /// UC 3 : Refactor 2: Finds the Maximum value among three using generic.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        private static T MaximumValueAmongThree(T firstValue, T secondValue, T thirdValue)
        {
            Console.WriteLine("Maximum value among {0}, {1} and {2}: ", firstValue, secondValue, thirdValue);
            /// Checks if firstValue is great then both secondValue and thirdValue
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
                return firstValue;
            /// Checks if secondValue is great then both firstValue and thirdValue
            else if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
                return secondValue;
            else
                return thirdValue;
        }
        /// <summary>
        /// UC 3 : Refactor 2 : Finds the maximum using generic
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            T maxValue = MaximumValueAmongThree(this.firstValue, this.secondValue, this.thirdValue);
            return maxValue;
        }
    }
}