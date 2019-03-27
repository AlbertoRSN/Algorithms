/******************************************************************************

@Author: Alberto Rodríguez Santana
@Email: alberodrisanta@gmail.com

*******************************************************************************/
using System;
class Program {
    
    static bool palindrome(string str){
        //1. If the string is made of no letters or just one letter, then it is a palindrome.
        if(str.Length < 2){
            return true;
        }
        
        //2. Otherwise, compare the first and last letters of the string.
        //If the first and last letters differ, then the string is not a palindrome.
        if(str[0] != str[str.Length - 1]){
            return false;
        }

        // 3. Otherwise, the first and last letters are the same. Strip them from the string, 
        //and determine whether the string that remains is a palindrome. Take the answer for 
        //this smaller string and use it as the answer for the original string.
        else{
            return palindrome(str.Substring(1, str.Length-2));
        }
        
    }
    
    
  static void Main() {
      
    string s1 = "rotor";
    string s2 = "motor";
    
    bool result = palindrome(s1);
    Console.WriteLine("Word '{0}' is palindrome = {1}",s1,result);
    
    result = palindrome(s2);
    Console.WriteLine("Word '{0}' is palindrome = {1}",s2,result);

  }
}
