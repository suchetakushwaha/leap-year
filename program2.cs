using System;
namespace LeapYear
{
  class Program2
  {
      static void Main(string[] args)
      {
          Console.WriteLine("Enter The Year");
          int year = Convert.ToInt32(Console.ReadLine());

          if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
          {
            Console.WriteLine("it is Leaap Year");
          }
          else {
              Console.WriteLine("it is not Leap Year");
          }
      }

  }
}



