﻿namespace ex2_llibreries
{
    public class FirstSort
    {
        public static void Complete(int[] v, int left, int m, int right)
        {
            int n = right - left + 1;
            int[] aux = new int[n];
            int k = 0;
            int i = left;
            int j = m + 1;
            while (i <= m && j <= right)
            {
                if (v[i] < v[j]) { aux[k] = v[i]; ++i; }
                else { aux[k] = v[j]; ++j; }
                ++k;
            }
            while (i <= m) { aux[k] = v[i]; ++i; ++k; }
            while (j <= right) { aux[k] = v[j]; ++j; ++k; }
            for (k = 0; k < n; ++k) v[left + k] = aux[k];
        }

        public static void Order(int[] v, int left, int right)
        {
            if (left < right)
            {
                int m = (left + right) / 2;
                Order(v, left, m);
                Order(v, m + 1, right);
                Complete(v, left, m, right);
            }
        }
    }
    public class SearchClass
    {
        public static int BinarySearch(int[] arr, int first, int last, int key)
        {
            if (last >= first)
            {
                int mid = first + (last - first) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] > key)
                {
                    return BinarySearch(arr, first, mid - 1, key);//cerca en el subarray esquerre
                }
                else
                {
                    return BinarySearch(arr, mid + 1, last, key);//cerca en el subarray dret
                }
            }
            return -1;
        }
    }
    public class SecondSort
	{
		public static void Swap(int[] arr, int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}

		public static int Divide(int[] arr, int low, int high)
		{
			int pivot = arr[high];
			int i = (low - 1);

			for (int j = low; j <= high - 1; j++)
			{
				if (arr[j] < pivot)
				{
					i++;
					Swap(arr, i, j);
				}
			}
			Swap(arr, i + 1, high);
			return (i + 1);
		}

		public static void Order(int[] arr, int low, int high)
		{
			if (low < high)
			{
				int pi = Divide(arr, low, high);
				Order(arr, low, pi - 1);
				Order(arr, pi + 1, high);
			}
		}
	}
}