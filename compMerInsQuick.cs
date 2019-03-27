
using System;
using System.Collections.Generic;
using System.Linq;
class HelloWorld {
    
    
    
        public static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    
    // ----- INSERTION SORT with LIST------
     public static List<int> insertionSort(List<int> numbers)
  { 
        int i, key, value;
        int comparisons = 0;
        long swaps = 0;

        for (i=1; i < numbers.Count; i++){
                key = numbers [i]; //the second value of the array
                value = i - 1; //the first value of the array
                
                    comparisons++;
                while (value >= 0 && numbers[value] > key){
                    //insertion of tahe correct number
                    numbers [value + 1] = numbers [value];
                    value = value - 1;
                    swaps++;
                    
                }
                
                numbers [value + 1] = key;
                //Console.WriteLine("----------------------------------");
                //printOut(numbers);
        }
        
        //Console.WriteLine("comparisons: {0}, Swaps: {1}", comparisons, swaps);
        return numbers;
   } 
   
   
   
    public static void QuickSort(List<int> list, int left, int right) 
	{
		if (left < right)
		{
			int pivot = Partition(list, left, right);

			if (pivot > 1) {
				QuickSort(list, left, pivot - 1);
			}
			if (pivot + 1 < right) {
				QuickSort(list, pivot + 1, right);
			}
		}
	
	}
        
     public static int Partition(List<int> list, int left, int right)
	{
		int pivot = list[left];
		while (true) 
		{

			while (list[left] < pivot) 
			{
				left++;
			}

			while (list[right] > pivot)
			{
				right--;
			}

			if (left < right)
			{
				if (list[left] == list[right]) return right;

				int tmp = list[left];
				list[left] = list[right];
				list[right] = tmp;
			}
			else 
			{
				return right;
			}
		}
	}
        
    //Print all elements    
	public static void PrintOut(List<int> list)
	{
		for (int i = 0; i < list.Count; i++)
		{
			Console.Write(list[i] + " ");
		}
		Console.WriteLine();
	}
   
   //Print only everyNth elements
    public static void PrintOutAll(List<int> list, int everyNth)
        {
            Console.WriteLine();
            for (int i = 0; i < list.Count; i++)
            {
                if(i % everyNth == 1)
                    Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        
   
    
  static void Main() {

    List<int> listOne = new List<int>();
    List<int> listTwo = new List<int>();
    List<int> listZero = new List<int>();
    List<int> listThree = new List<int>();
    
    
    Random random = new Random();
    
    DateTime start;
    TimeSpan timeItTook;
    
    int n = 50000; int th = 5000;

    for (int i = 0; i < n; i++)
    {
		listZero.Add(random.Next(0, 30));
		listOne.Add(0);
		listTwo.Add(0);
		listThree.Add(0);
    }
    
    for (int i = 0; i < n; i++)
    {
        listOne[i] = listZero[i];
        listTwo[i] = listZero[i];
        listThree[i] = listZero[i];
    }

    Console.WriteLine(listOne.Sum());
    Console.WriteLine(listTwo.Sum());
    Console.WriteLine(listThree.Sum());
    // ---------- LIST ONE ----------       
	//Console.WriteLine("Unsorted listOne:");
    //PrintOutAll(listOne, th);     

    Console.WriteLine("\nSorting by MERGE");
    
    start = DateTime.Now;
    listOne = MergeSort(listOne);    
    timeItTook  = DateTime.Now - start;
    //Console.WriteLine("Sorted list: ");
    PrintOutAll(listOne, th);

    Console.WriteLine("\nIt took " + timeItTook);
    Console.WriteLine("------------------");
    
    
    // ---------- LIST TWO ----------  
    //Console.WriteLine("Unsorted listTwo:");
    //PrintOutAll(listOne, th);     

    Console.WriteLine("\nSorting by INSERTION");
    
    start = DateTime.Now;
    listTwo = insertionSort(listTwo);    
    timeItTook  = DateTime.Now - start;
    //Console.WriteLine("Sorted list: ");
    PrintOutAll(listTwo, th);

    Console.WriteLine("\nIt took " + timeItTook);
    Console.WriteLine("------------------");
    
    
     // ---------- LIST THREE ----------  
    Console.WriteLine("\nSorting by QUICK SORT");
    
    start = DateTime.Now;
    QuickSort(listThree, 0, listThree.Count-1);
    timeItTook  = DateTime.Now - start;
    //Console.WriteLine("Sorted list: ");
    PrintOutAll(listThree, th);

    Console.WriteLine("\nIt took " + timeItTook);
    Console.WriteLine("------------------");


    }

}
    


