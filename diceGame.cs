namespace diceGame
{
class DiceGame
    {
        public static void Main(string[] args)
        {
        // This is a simple dice game where the player rolls a die and the computer rolls a die. 
        // The player with the higher number wins.

            int playerRandomNum = 0 ;
            int computerRandomNum = 0;
            Random random = new Random();

            int playerPoints = 0;
            int computerPoints = 0;


        // Loop to allow the player to roll the dice 5 times
        // The player rolls the dice and the computer rolls the dice. The player with the higher number wins.

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey(true);//the use of true does not display the key pressed in the console window
                                      // keeps the ui clean

                playerRandomNum = random.Next(1, 7);
                System.Console.WriteLine("You rolled a " + playerRandomNum);
                System.Console.WriteLine(".......");

                // Wait for 1 second before showing the computer's roll
                System.Threading.Thread.Sleep(1000); 

                computerRandomNum = random.Next(1, 7);
                System.Console.WriteLine("Computer rolled a " + computerRandomNum);

        // Compare the player's roll to the computer's roll and determine the winner

            if (playerRandomNum > computerRandomNum)
            {
                System.Console.WriteLine("You win!");
                playerPoints++;
            }
            else if (playerRandomNum < computerRandomNum)
            {
                System.Console.WriteLine("Computer wins!");
                computerPoints++;
            }
            else
            {
                System.Console.WriteLine("It's a tie!");
            
            }
            System.Console.WriteLine("the score is: Player: " + playerPoints + " Computer: " + computerPoints);
            }

            // After 5 rounds, determine the overall winner based on the points

            if (playerPoints > computerPoints)
            {
                System.Console.WriteLine("You are the overall winner!");
            }
            else if (playerPoints < computerPoints)
            {
                System.Console.WriteLine("Computer is the overall winner!");
            }
            else
            {
                System.Console.WriteLine("It's an overall tie!");
            }

            System.Console.WriteLine("Game over! Thanks for playing." );
            
        // Wait for the player to press a key before closing the console window

            Console.ReadKey();
            
            } 

        }

    }