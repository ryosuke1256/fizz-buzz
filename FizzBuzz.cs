using System;

namespace source {
  class Program {
    public static void Main(string[] args) {
      FizzBuzz fizzBuzz = new FizzBuzz();
      for(ushort i=1;i<=30;i++) {
        Console.WriteLine(fizzBuzz.Exec(i));
      }
    }
  }

  class FizzBuzz {
    public string Exec(ushort num) {
        if (num % 15 == 0) return "FizzBuzz";
        if (num % 3 == 0) return "Fizz";
        if (num % 5 == 0) return "Buzz";
        return num.ToString();
    }
  }
}
