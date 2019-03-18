/******************************************************************************
@Author: Alberto Rodríguez Santana
@Email: alberodrisanta@gmail.com

1. Create an array of random values (f.e. 1000).

2. Sort the array with any sorting algorithm.

3. Fin the value (the target) in the sorted array using binary search algorithm.

*******************************************************************************/
using System;
class Program {
    
    public static void printOut( int[] arr, int everyNth){
            Console.WriteLine();
            for(int i=0; i <arr.Length; i++){
                if(i % everyNth == 1)
                    Console.Write(arr[i] + " ");
            }    
            Console.WriteLine();
        } 
        
     public static void printOutAll( int[] arr){
            Console.WriteLine();
            for(int i=0; i <arr.Length; i++){
                    Console.Write(arr[i] + " ");
            }    
            Console.WriteLine();
        } 
        
    // ----- INSERTION SORT ------
     public static int[] insertionSort(int[] numbers, bool display=false)
  { 
        int i, key, value;
        int comparisons = 0;
        long swaps = 0;

        for (i=1; i < numbers.Length; i++){
                key = numbers [i]; //the second value of the array
                value = i - 1; //the first value of the array
                if(display){
                    comparisons++;
                }
                while (value >= 0 && numbers[value] > key){
                    //insertion of tahe correct number
                    numbers [value + 1] = numbers [value];
                    value = value - 1;
                    if(display){
                        swaps++;
                    }
                }
                
                numbers [value + 1] = key;
                //Console.WriteLine("----------------------------------");
                //printOut(numbers);
        }
        
        Console.WriteLine("comparisons: {0}, Swaps: {1}", comparisons, swaps);
        return numbers;
   } 
   
   
    public static int binarySearchTarget(int[] array, int targetValue) {
	    int min = 0;
	    int max = array.Length - 1;
        int guess;
        int result = -1;
    
        while ( min <= max ) {
            guess = ((min + max)/2);
            if (array[guess] == targetValue) { 
              result = guess; 
            } 
    
            if (array[guess] < targetValue ) {
                min = guess + 1;
            } 
            else { 
                max = guess - 1; 
            } 
        }
     return result;
    }

  static void Main() {
    
    int min = 0; int max = 30;
    int th = 5; int n=20;
    Random random = new Random();
    int target = 7;
    
    
    int[] list = new int[n];
    
    //the array of N random integers
        for (int i = 0; i < n; i++)
        {
            list[i] = random.Next(min, max);
        }
        
    Console.WriteLine("\nThe initial Array is: ");
    printOut(list, th);
    
    Console.WriteLine("\nSorting List with INSERTION algorithm");
    list = insertionSort(list, true);
    printOutAll(list);
    Console.WriteLine("------------------");
    
    int result = binarySearchTarget(list, target);
    
    if(result == -1){
        Console.WriteLine("The value {0} is not found ", target);
    }
    else{
       Console.WriteLine("Found target number -{0}- at index -{1}-", target,result); 
    }
  }
}


