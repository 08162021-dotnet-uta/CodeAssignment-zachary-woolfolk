using System;

namespace SweetnSaltyConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      //number of elements on a single line
      int printCount = 0; 
      //number of elements that are multiples of 3
      int sweetCount = 0;
      //number of elements that are multiples of 5
      int saltyCount = 0;
      //number of elements that are multiples of both 3 and 5
      int sweetNSaltyCount = 0;

      //loop to check each integer from 1 to 1000
      for(int i = 1; i <= 1000; i++)
      {
        //If there's room on the line (only 10 elements allowed)
        //and the current number is divisible by both 3 and 5,
        //print the appropriate string
        if ((i % 3 == 0 && i % 5 == 0) && printCount < 10)
        {
          sweetNSaltyCount++;
          Console.Write("sweet'nSalty ");
        }
        //Print appropriate string for number divisible by 3
        //if there's room on the line
        else if(i % 3 == 0 && printCount < 10)
        {
          sweetCount++;
          Console.Write("sweet ");
        }
        //Print appropriate string for number divisible by 5
        //if there's room on the line
        else if (i % 5 == 0 && printCount < 10)
        {
          saltyCount++;
          Console.Write("salty ");
        }
        //If current number meets none of the preceding criteria,
        //and there's room on the line, print the number.
        else if(printCount < 10)
        {
          Console.Write(i + " ");
        }
        //If this block is reached, the current line is full (it has 10 elements).
        //The current number has been skipped by the print statements.
        //Decrement it so that i has the correct value after being updated at the end of the loop.
        //Reset the element counter and start a new line.
        else
        {
          i--;
          printCount = -1;
          Console.Write("\n");
        }
        printCount++;
      }
      //Print the counting results
      Console.WriteLine("\n");
      Console.WriteLine("Sweets: " + sweetCount);
      Console.WriteLine("Saltys: " + saltyCount);
      Console.WriteLine("SweetNSalty: " + sweetNSaltyCount);
    }
  }
}
