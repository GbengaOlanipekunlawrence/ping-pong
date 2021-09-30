using System;

namespace PingPong
{
    class Program
    {
    static void Main(string[] args)
    {

      Console.WriteLine("Ping Pong");
      Console.WriteLine("Please Enter A Number");
      string userNumber = Console.ReadLine();
      int number = int.Parse(userNumber);
      for (int i = 1; i <= number; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("Ping Pong");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("Ping");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("Pong");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
        // int number;
        //
        // Console.WriteLine("Please enter a number divisible by 3:");
        // number = int.Parse(Console.ReadLine());
        //
        // if(number % 3)
        // Console.WriteLine("Hey! The number should is divisible by  3");
        // else
        // if(number  0)
        //     Console.WriteLine("Hey! The number should be 0 or more!");
        // else
        //     Console.WriteLine("Good job!");
        //
        // Console.ReadLine();
    }
    }
}
