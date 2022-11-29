using System;
namespace Debugging_Algorithms
{
	public class loops
	{
		public void go()
		{
			Console.WriteLine("----EX 1---- ");


			int[] array = new int[] { 1, 2, 3, 4, 5, };

			int sum = 0;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i]%2 == 0)
				{
					sum += array[i];
				}
			}
			Console.WriteLine("the total of the even given numbers is " +sum);
		}
	}
	public class ex1Alternative
	{
		public void go()
		{
            Console.WriteLine(" ex 1 modified");
            Console.WriteLine("Please insert the last number of your array, assume it starts from 1");
            int j = Convert.ToInt32(Console.ReadLine());
            j += 1;
            int[] array1 = new int[j];
            for (int i = 0; i < j; i++)
            {
                array1[i] = i;
                
            }
			Console.WriteLine();
            int sum2 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
				if (array1[i]%2==0)
				{
					sum2 += array1[i];
				}
            }
			Console.WriteLine(" the total of the even given  numbers is :" +sum2);
        }
	}

	public class exercise2
	{
		public void go()
		{
			Console.WriteLine("---Ex 2---");
			int[] array = new int[] { 1, 2, 3, 3, 4 };
			Array.Sort(array);
			List<int> list = new List<int>();
			for (int i = 0; i < array.Length-1; i++)
			{
				if (array[i] == array[i+1])
				{
					list.Add(array[i]);
					Console.WriteLine($"The item {array[i]} is already present in the array");
				}
			}

		}

	}

	public class exercise3
	{
		public void go()
		{
			Console.WriteLine(" --- EX 3 ---");

			List<string> list = new List<string> { "a", "b", "b", "c", "c", "d", };

			List<string> results = new List<string> { };



            for (int i = 0; i < list.Count ; i++)
			{
				bool duplicate = false;
				for (int j = 0; j < i; j++)
				{
					if (list.ElementAt(i)==list.ElementAt(j))
					{
						duplicate = true;
						break;
					}
				}
				if (!duplicate)
				{
					results.Add(list[i]);
				}

			
			}
			Console.Write("The list without duplicates : ");
			results.ForEach(Console.Write);

			Console.WriteLine();
		}
	}

	public class exercise4
	{
		public void go()
		{
			Console.WriteLine("--- EX 4 ---");
			int[] array = new int[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
			int[] frequency = new int[array.Length];
			int visited = -1;
			for (int i = 0; i < array.Length; i++)
			{
				int count = 1;
				for (int j = i+1 ; j < array.Length; j++)
				{
					if (array[i] == array[j])
					{
						count++;
						frequency[j] = visited;
					}
				}
				if (frequency[i]!=visited)
				{
					frequency[i] = count;
				}
			}

			for (int i = 0; i < frequency.Length; i++)
			{
				if (frequency[i]!=visited)
				{
					Console.WriteLine(" The element  "+ array[i]+ " has a frequence of " + frequency[i] + " times ");
				}
			}
        }
	
	}

	public  class exercise5
	{
		public void go()
		{

			Console.WriteLine(" --- EX 5----");
            Console.WriteLine("Please insert the number of elements of your array");
            int j = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[j];
			int[] even = new int[j];
			int[] odd = new int[j];
			int k = 0, m = 0;
			Console.WriteLine("Please insert the elements of your array : ");
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToInt32(Console.ReadLine());
				
			}
            for (int i = 0; i < j; i++)
            {
				if (array[i]%2==0)
				{
					even[k] = array[i];
					k++;
				}
				else
				{
					odd[m] = array[i];
					m++;
				}
            }

			Console.WriteLine( "The even numbers are : ");
			for (int i = 0; i < k; i++)
			{
				Console.Write("{0} ", even[i]);

            }
			Console.WriteLine();

			Console.WriteLine("The odd numbers are : ");

			for (int i = 0; i < m; i++)
			{
				Console.Write("{0} ", odd[i]);
			} 
        }
	}

}

