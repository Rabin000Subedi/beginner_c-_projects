namespace GuessNumber
{
class Program
    {
        public static void Main(string[] args)
        {
        bool isCorrectguess = false;
        Random random = new Random();
        int randomNum = random.Next(1, 11);

        System.Console.WriteLine("Welcome to the Guess the Number Game!" );
        System.Console.WriteLine("Guess a number between 1 and 10: ");
        System.Console.WriteLine("Guess the correct number to win the game!");

        int attempts = 0;
        while(!isCorrectguess)
            {
                System.Console.WriteLine("Enter your guess: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < randomNum)
                {
                    System.Console.WriteLine("Your guess is too low. Try again.");
                    attempts++;
                }
                else if (userGuess > randomNum)
                {
                    System.Console.WriteLine("Your guess is too high. Try again.");
                    attempts++;
                }
                else
                {
                    System.Console.WriteLine("Congratulations! You guessed the correct number!");
                    isCorrectguess = true;
                }
            }
            System.Console.WriteLine("Congratulations! You guessed the correct number in " + attempts + " attempts.");
            System.Console.WriteLine("Thank you for playing the Guess the Number Game!");

        }}}

        









    
    


