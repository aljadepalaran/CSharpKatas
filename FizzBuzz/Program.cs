class Program {
  public static void Main(string[] args){
    Console.WriteLine("Welcome to FizzBuzz");
    Console.Write("How many numbers would you like: ");
    string? input = Console.ReadLine();

    if (input == null) {
      Console.WriteLine("Please enter a valid number.");
      return;
    }
    try
    {
      var numberRange = int.Parse(input);
      for (int counter = 1; counter <= numberRange; counter++)
      {
        Console.WriteLine(FizzBuzz(counter));
      }
    }
    catch (FormatException)
    {
      Console.WriteLine("Please enter a valid number.");
      return;
    }
  }

  static string FizzBuzz(int number)
  {
    if ((number % 3 == 0) && (number % 5 == 0)) {
      return "FizzBuzz";
    } else if (number % 3 == 0) {
      return "Fizz";
    } else if (number % 5 == 0) {
      return "Buzz" ;
    } else {
      return number.ToString();
    }
  }
}
