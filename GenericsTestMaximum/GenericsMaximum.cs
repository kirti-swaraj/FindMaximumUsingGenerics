using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum
{
    public class GenericMaximum<T> where T : IComparable
    { 
       public T[] value;

            public GenericMaximum(T[] value)
            {
                this.value = value;
            }

            /// <summary>
            /// UC 4 : Sorts the specified values.
            /// </summary>
            /// <param name="values">The values.</param>
            /// <returns></returns>
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }

            /// <summary>
            /// UC 4 : Finds Maximum value.
            /// </summary>
            /// <param name="values">The values.</param>
            /// <returns></returns>
            private T MaxValue(params T[] values)
            {
                var sortedValues = Sort(values);
                return sortedValues[^1];
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
                var maxValue = MaxValue(this.value);
                return maxValue;
            }
        }
    }
