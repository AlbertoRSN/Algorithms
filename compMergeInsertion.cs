
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
    List<int> sorted1;


    List<int> listTwo = new List<int>();
    List<int> sorted2;
    
    Random random = new Random();
    
    DateTime start;
    TimeSpan timeItTook;
    
    int n = 50000; int th = 100;

    for (int i = 0; i < n; i++)
    {
		listOne.Add(random.Next(0, 30));
    }
       
    for (int i = 0; i < n; i++)
    {
		listTwo.Add(random.Next(0, 30));
    }     
    
    // ---------- LIST ONE ----------       
	//Console.WriteLine("Unsorted listOne:");
    //PrintOutAll(listOne, th);     

    Console.WriteLine("\nSorting by MERGE");
    
    start = DateTime.Now;
    sorted1 = MergeSort(listOne);    
    timeItTook  = DateTime.Now - start;
    Console.WriteLine("Sorted list: ");
    PrintOutAll(sorted1, th);

    Console.WriteLine("\nIt took " + timeItTook);
    Console.WriteLine("------------------");
    
    
    // ---------- LIST TWO ----------  
    //Console.WriteLine("Unsorted listTwo:");
    //PrintOutAll(listOne, th);     

    Console.WriteLine("\nSorting by INSERTION");
    
    start = DateTime.Now;
    sorted2 = insertionSort(listTwo);    
    timeItTook  = DateTime.Now - start;
    Console.WriteLine("Sorted list: ");
    PrintOutAll(sorted2, th);

    Console.WriteLine("\nIt took " + timeItTook);
    Console.WriteLine("------------------");
    


    }

}
    


