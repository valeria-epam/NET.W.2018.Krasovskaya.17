using System;
using System.Collections.Generic;

namespace No6
{
    public static class GenericGenerator
    {
        public static IEnumerable<T> Generator<T>(T firstNumber, T secondNumber, Func<T, T, T> function)
        {
            yield return firstNumber;
            yield return secondNumber;

            T first = firstNumber;
            T second = secondNumber;

            while (true)
            {
                T next = function(first, second);
                yield return next;

                first = second;
                second = next;
            }
        }
    }
}
