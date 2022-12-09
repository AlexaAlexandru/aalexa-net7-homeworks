using System;

// sorting algorithm with Quicksort method

namespace Debugging_Algorithms
{
	public class AlgorithmInsertion
	{
		void Sort(int []array)
		{
			int len = array.Length;

			for (int i = 1; i < len; ++i)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }

        }
		static void printArray(int[] array)
		{
			int len = array.Length;
			Console.WriteLine(" The sorted array is :");
			for (int i = 0; i < len; i++)
			{
				Console.Write(array[i]+ " ");
			}

		}
		public void Main()
		{
			Console.WriteLine(" Sorting Algorithm with Insertion method ");
			int[] array = new int[] { 3, 6, 1, 9, 53, 10, 2 };

			Console.WriteLine(" The input array is : ");
			for (int i =0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
			Console.WriteLine();
			AlgorithmInsertion ob = new AlgorithmInsertion();
			ob.Sort(array);
			printArray(array);
			
            Console.WriteLine("\n");
        }
	}

	public class AlgorithmQuicksort
	{
		static void swap(int[]array, int i, int j)
		{
			int temp = array[i];
			array[i] = array[j];
			array[j] = temp;

		}
		static int Partition( int[] array, int low, int high)
		{
			int pivot = array[high];
			int i = (low - 1);
			for (int j = low; j <= high-1; j++)
			{
				if (array[j]<pivot)
				{
					i++;
					swap(array, i, j);
				}

				
			}
            swap(array, i + 1, high);
            return (i + 1);

        }
		static void quickSort(int[]array,int low, int high)
		{
			if (low<high)
			{
				int pi = Partition(array, low, high);
				quickSort(array, low, pi - 1);
				quickSort(array, pi + 1, high);
			}
		}
		static void printArray(int[]array, int size)
		{
            for (int i = 0; i < size; i++)
			{

                Console.Write(array[i] + " ");
            }
            
        }
        
		public void Main()
		{
			Console.WriteLine(" Sorting Algorithm with Quicksort method");
			
			int[] array = new int[] {3,6,1,9,53,10,2};
            int n = array.Length;
            Console.WriteLine("input array: ");
			for (int i = 0; i < n; i++)
			{
				Console.Write(array[i] + " ");
			}
            Console.WriteLine();

            quickSort(array, 0, n - 1);
            Console.WriteLine("Sorted array: ");
            printArray(array, n);
			Console.WriteLine();
        }
	}

	public class SearchAlgorithm
	{
		static int binarySearch(int[] array, int l, int r, int x)
		{
			if (r>=1)
			{
				int mid = 1 + (r - 1) / 2;
				if (array[mid]==x)
				{
					return mid;
				}
				if (array[mid]>x)
				{
                    			return binarySearch(array, l, mid - 1, x);
            			}
				else
				{
					return binarySearch(array, mid + 1, r, x);
				}
            }
			return -1;
		}
		public void Main()
		{
			Console.WriteLine("\n");
			Console.WriteLine(" Binary Search ");
			int[] array = new int[] { 2, 4, 6, 8, 10, 14, 44, 54 };
			int n = array.Length;
			int x = 10;
			int result = binarySearch(array, 0, n - 1, x);
			if (result==-1)
			{
                Console.WriteLine("Element not present");
            }
			else
			{
                Console.WriteLine("Element found at index : " + result);
            }
		}
	}
}

