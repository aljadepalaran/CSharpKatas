class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to number guesser!");

        while(true)
        {
            DisplayOptions();
            int choice = FetchSelection();
            if (choice == 2) 
            {
                break;
            }
            else
            {
                PlayGame();
            }
        }
    }

    public static void DisplayOptions()
    {
        Console.WriteLine("What would you like to do?");
        Console.Write("""
            1. Play
            2. Exit
            Your choice: 
        """);
    }

    public static int FetchSelection()
    {
        return int.Parse(Console.ReadLine());
    }

    public static void PlayGame(int numberToGuess = default)
    {
        if (numberToGuess == default)
        {
            numberToGuess = new Random().Next(9999);
        }

        Console.WriteLine("Guess my number: ");
        int userGuess = int.Parse(Console.ReadLine());
        var result = ProcessGuess(numberToGuess, userGuess);
        if (result) { return; }

        PlayGame(numberToGuess);
    }
    public static bool ProcessGuess(int answer, int guess)
    {
        if (guess == answer)
        {
            Console.WriteLine("Congratulations! You have guessed my number!");
            return true;
        }
        if (guess > answer)
        {
            Console.WriteLine("Try a smaller number!");
        }
        if (guess < answer)
        {
            Console.WriteLine("Try a larger number!");
        }
        return false;
    }
}