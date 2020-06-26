using System;
using System.Runtime.InteropServices;

namespace MinimaMaxima
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new decimal[] { 10, 3, 10, 10, 5, 30, 40, 50, 45, 30, 35, 30 };
            var arr2 = RemoveSameConsecutiveValues(arr);

            var narr = FindMinimaMaxima(arr2);
            
            var narr2 = FindMinimaMaxima(narr.Data);
            
            var narr3 = FindMinimaMaxima(narr2.Data);


            Console.WriteLine("Hello World!");
        }

        static decimal[] RemoveSameConsecutiveValues(decimal[] arr)
        {
            var l = arr.Length;
            var arr2 = new decimal[l];
            var j = 0;
            arr2[j++] = arr[0];
            for (var i = 1; i < l; i++)
            {
                if (arr2[j - 1] != arr[i])
                {
                    arr2[j++] = arr[i];
                }
            }
            var finalArr = new decimal[j];
            Array.Copy(arr2, finalArr, j);
            return finalArr;
        }

        static (decimal[] Minima, decimal[] Maxima, decimal[] Data) FindMinimaMaxima(decimal[] data)
        {
            var tmpArr = new decimal[data.Length];
            var minArr = new decimal[data.Length];
            var maxArr = new decimal[data.Length];

            var j = 0;
            var min = 0;
            var max = 0;
            for (var i = 1; i < data.Length - 1; i++)
            {
                if (data[i - 1] > data[i] && data[i] < data[i + 1])
                {
                    tmpArr[j++] = data[i];
                    minArr[min++] = data[i];
                }
                else if (data[i - 1] < data[i] && data[i] > data[i + 1])
                {
                    tmpArr[j++] = data[i];
                    maxArr[max++] = data[i];
                }
            }
            var rdata = new decimal[j];
            Array.Copy(tmpArr, rdata, j);

            var minData = new decimal[min];
            Array.Copy(minArr, minData, min);

            var maxData = new decimal[max];
            Array.Copy(maxArr, maxData, max);

            return (minData, maxData, rdata);
        }
    }
}
