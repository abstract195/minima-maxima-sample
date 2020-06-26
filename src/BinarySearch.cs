using System;
using System.Collections.Generic;
using System.Text;

namespace MinimaMaxima
{
    static class BinarySearch
    {
        public static (decimal Minima, decimal Maxima) Find(decimal[] arr)
        {
            var rmin = Minima(arr, 0, arr.Length - 1, arr.Length);
            var rmax = Maxima(arr, 0, arr.Length - 1, arr.Length);
            return (arr[rmin], arr[rmax]);
        }
        public static int Minima(decimal[] arr, int start, int end, int length)
        {
            var m = start + ((end - start) / 2);

            if (m == 0)
                return m;

            if (m == length - 1)
                return m;

            if (arr[m - 1] > arr[m] && arr[m] < arr[m + 1])
                return m;

            if (arr[m - 1] < arr[m])
                return Minima(arr, start, m, length);

            if (arr[m + 1] > arr[m])
                return Minima(arr, m, end, length);

            return -1;
        }

        public static int Maxima(decimal[] arr, int start, int end, int length)
        {
            var m = start + ((end - start) / 2);

            if (m == 0)
                return m;

            if (m == length - 1)
                return m;

            if (arr[m - 1] < arr[m] && arr[m] > arr[m + 1])
                return m;

            if (arr[m - 1] < arr[m])
                return Maxima(arr, m, end, length);

            if (arr[m + 1] > arr[m])
                return Maxima(arr, start, m, length);

            return -1;
        }
    }
}
