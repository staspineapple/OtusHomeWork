﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otushomework8
{
    internal static  class Ext
    {
            public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
            {
                float max = float.MinValue;
                T maxElement = null;

                foreach (var element in collection)
                {
                    float number = convertToNumber(element);

                    if (number > max)
                    {
                        max = number;
                        maxElement = element;
                    }
                }
                return maxElement;
            }
        }
    
}
