using System;
using System.Collections.Generic;
using System.Linq;

namespace cv7
{
    public class Extreme
    {
        public static T Min<T>(T[] values) where T : IComparable
        {
            if (values.Length == 0)
            {
                throw new ArgumentException("Input is empty");
            }

            T min = values[0];

            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i].CompareTo(min) < 0)
                {
                    min = values[i];
                }
            }

            return min;
        }

        public static T Max<T>(T[] values) where T : IComparable
        {
            if (values.Length == 0)
            {
                throw new ArgumentException("Input is empty");
            }

            T max = values[0];

            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }

            return max;
        }
    }
}
