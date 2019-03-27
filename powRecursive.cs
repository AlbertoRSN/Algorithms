using System;
class Program {
    
   
    public static double Pow (double xBase, double yPower){
        if(yPower == 0){
            return 1;
        }
        else{
            return xBase * Pow(xBase, yPower - 1);
        }
    }


  static void Main() {
    
    Console.WriteLine(Pow(2,4));
  }
}

