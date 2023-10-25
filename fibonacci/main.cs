using Internal;

using System;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
        int fib = 1, v  = 1, vv = 1;
        Console.Write("Geben sie das Maximum einer Fobinacci Zahl ein: ");
        int count = Int32.Parse(Console.ReadLine());
        Console.WriteLine("1 : 1");
        Console.WriteLine("2 : 1");
        for(int i = 3; i <= count; i++) {
          fib = vv + v;
          vv = v;
          v = fib;
          Console.WriteLine(i + ": " + fib);
        }
    }
  }
}