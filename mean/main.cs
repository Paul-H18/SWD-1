using System;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {


      Console.WriteLine("Welcome\nEnter 0 to end!");

      int counter = 0;
      double sum = 0, input;

      do {
          Console.Write("Enter Value (double with comma): ");
          input = Double.Parse(Console.ReadLine());
          sum += input;
          Console.WriteLine(input);
          counter++;
          if(input != 0) {
            Console.WriteLine("Mean: " + Convert.ToString(sum/counter));
          } else {
            Console.WriteLine("Closing...");
          }
      } while(input != 0);
    }
  }
}