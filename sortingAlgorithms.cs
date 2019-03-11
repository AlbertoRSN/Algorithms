/******************************************************************************

SORTING ALGORITHMS

*******************************************************************************/
using System;
class Program{
    
    public static void printOut( int[] arr, int everyNth){
            Console.WriteLine();
            for(int i=0; i <arr.Length; i++){
                if(i % everyNth == 1)
                    Console.Write(arr[i] + " ");
            }    
            Console.WriteLine();
        }    
    
        // ------- BUBBLE SORT --------
        public static int[] BubleSort(int[] tab){
            int n = tab.Length;
            int comparisons = 0;
            int swaps = 0;
            do{
                //swapped = false;
                for(int i=0; i< n-1; i++){
                    int tmp = tab[i];
        
                    if(tmp > tab[i+1]){
                        //tab.swap(tab[i],tab[i+1]);
                        tab[i]=tab[i+1];
                        tab[i+1]=tmp;
                        swaps++;
                        //swapped = true;
                    }
                    comparisons++;
                    //printOut(tab);
                    //Console.WriteLine();
                }
                n= n-1;
            }while(n != 1);
            
            Console.WriteLine("comparisons: {0}, Swaps: {1}", comparisons, swaps);
            return tab;
        }
        
        
    // ----- INSERTION SORT ------
     public static int[] insertionSort(int[] numbers)
  { 
        int i, key, value;
        int comparisons = 0;
        long swaps = 0;

        for (i=1; i < numbers.Length; i++){
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
        
        Console.WriteLine("comparisons: {0}, Swaps: {1}", comparisons, swaps);
        return numbers;
   } 
   
   
   
   //--------- SELECTION SORT -----------
   public static int getMin(int[] arr, int start)
        {
            int min = arr[start];
            int minIndex = start;
            for (int i = start + 1; i < arr.Length; i++)
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            return minIndex;
        }

        public static int[] sortBySelection(int[] arr)
        {
            int comparisons = 0;
            long swaps = 0;
            int minIndex;
            for (int i = 0; i < arr.Length; i++)
            {
                int tmp = arr[i];
                minIndex = getMin(arr, i);
                if (i != minIndex)
                {
                   arr[i] = arr[minIndex];
                   arr[minIndex] = tmp;
                   swaps++;      
                }
            }
            Console.WriteLine("comparisons: {0}, Swaps: {1}", comparisons, swaps);
            return arr;
        }
    
    
    static void Main(){
        
        DateTime start;
        TimeSpan timeItTook;
        int n = 50000; int th = 5000;
        int min = 0; int max = 500;
        Random random = new Random();
        
        int[] tab={1,0,4,8,11,3,8,-2,5};
        
        int[] listZero = new int[n];
        int[] listOne = new int[n];
        int[] listTwo = new int[n];
        int[] listThree = new int[n];
        
        //the array of N random integers
        for (int i = 0; i < n; i++)
        {
            listZero[i] = random.Next(min, max);
        }
        
        for (int i = 0; i < n; i++)
        {
            listOne[i] = listZero[i];
            listTwo[i] = listZero[i];
            listThree[i] = listZero[i];
        }
        
        tab = listZero;
        Console.WriteLine("The original array has {0} values. Every {1}th is printed out. ", n, th);
        printOut(listZero, th);
        Console.WriteLine("\n------------------");
        
        
        
        Console.WriteLine("\nSorting by Bubble");
        start = DateTime.Now;
        listOne = BubleSort(listOne);
        timeItTook  = DateTime.Now - start;
        printOut(listOne, th);
        Console.WriteLine("\nIt took " + timeItTook);
        Console.WriteLine("------------------");

        Console.WriteLine("\nSorting by Insertion");
        start = DateTime.Now;
        listTwo = insertionSort(listTwo);
        timeItTook  = DateTime.Now - start;
        printOut(listTwo, th);
        Console.WriteLine("\nIt took " + timeItTook);
        Console.WriteLine("------------------");
        
        Console.WriteLine("\nSorting by Selection");
        start = DateTime.Now;
        listThree = sortBySelection(listThree);
        timeItTook  = DateTime.Now - start;
        printOut(listThree, th);
        Console.WriteLine("\nIt took " + timeItTook);
        Console.WriteLine("------------------");
    }
    
}




