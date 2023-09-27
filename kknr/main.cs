using System;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
        //2718 2818 2845 8567 - index 15 is check digit
        //2718281828458567 
        int[] ccnr = new int[16] {2, 7, 1, 8, 2, 8, 1, 8, 2, 8, 4, 5, 8, 5, 6, 7};

        int sum = 0, roundedUp;


        /*
        Possible solution, number needs to be split into an Array of 16
        ulong ccnr = Convert.ToUInt64(Console.ReadLine());
        Console.WriteLine(ccnr);
        */


        //get credit-card-number from user

        for(int i = 0; i <= 15; i++) {
          if(i == 15) {
            Console.Write("Geben Sie die Prüfziffer (Stelle " + Convert.ToString(i + 1) + ") ein: ");
            ccnr[i] = Int32.Parse(Console.ReadLine());
          } else {
            Console.Write("Geben Sie Ziffer " + Convert.ToString(i + 1) + " ein: ");
            ccnr[i] = Int32.Parse(Console.ReadLine());
          }
        }

        int checkDigit = ccnr[15];


        for(int i = 0; i <= 14; i++) {
            if((i % 2 == 0) || i == 0) {
              sum += crossSum(ccnr[i] * 2);
            } else {
              sum += ccnr[i];
            }
        }
        roundedUp = roundUp(sum);
        Console.WriteLine("Prüfziffer: " + checkDigit);
        Console.WriteLine("Result: " + (roundedUp - sum));
    }


    static int crossSum(int n) 
    {
      int sum = 0;
      while (n != 0) {
          sum += n % 10;
          n /= 10;
      }
      return sum;
    }


    static int roundUp(int num)
    {
      while((num % 10) != 0) {
        num++;
      }
      return num;
    }



  }
}