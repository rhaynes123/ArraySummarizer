using System;
using System.Linq;
/*
Description: Print the sum of the array's elements as a single integer.
Each method goes in the order of most code need to complete task to least amount of code.
This isn't meant to show which is better for performance just to give an example of flexible options.
*/

class ArraySummarizer
{
	public static int sum1 = 0;
	public static int sum2 = 0;
	public static int sum3 = 0;
	
	public static int[] arr = new int[] { 1, 2, 3 };
	
	static void Main(string[] args)
	{
		Console.WriteLine(UsingForEach());
		Console.WriteLine(UsingForLoop());
		Console.WriteLine(UsingLinq());
	}
	//------------------ For loop method
	public static int UsingForLoop()
	{
		for (int i = 0; i < arr.Length; i++)
		{
			sum1 += arr[i];
		}
		return sum1;
	}
	//------------------ For each loop method
	public static int UsingForEach()
	{
		foreach (var item in arr)
		{
			sum2 += item;
			
		}
		return sum2;
	}
	//------------------ Ling method
	public static int UsingLinq()
	{
		sum3 = arr.Sum();
		return sum3;
	}

	
}