using System;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
        //2718 2818 2845 8567 - 7 ist prüfziffer
        int[] ccnr = new int[15] {2, 7, 1, 8, 2, 8, 1, 8, 2, 8, 4, 5, 8, 5, 6};

        int vn = 7;

        int sum = 0, roundedUp;

        for(int i = 0; i <= 14; i++) {
            if((i % 2 == 0) || i == 0) {
              sum += quersumme(ccnr[i] * 2);
            } else {
              sum += ccnr[i];
            }
        }
        roundedUp = roundUp(sum);
        Console.WriteLine("Prüfziffer: " + vn);
        Console.WriteLine("Result: " + (roundedUp - sum));
    }

    static int quersumme(int n) 
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