using System;

namespace Source {
  class Program {
    private static void Main(string[] args) {
      FizzBuzz fizzBuzz = new FizzBuzz();
      for(ushort i = 1; i <= 30; i++) {
        Console.WriteLine(fizzBuzz.Call(callCount: i));
      }
    }
  }

  class FizzBuzz {
    public string Call(ushort callCount) {
      return (callCount % 15 == 0) ? "FizzBuzz" :
        (callCount % 3 == 0) ? "Fizz" :
        (callCount % 5 == 0) ? "Buzz" :
        callCount.ToString();
    }
  }
}
