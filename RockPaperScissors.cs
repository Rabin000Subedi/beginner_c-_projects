namespace RockPaperScissors
{
 class Program
  {
   public static void Main(string[] args)
        {
            Random random = new Random();
            
            int playerScore = 0;
            int computerScore = 0;


            while (playerScore!=3 && computerScore!=3){
             System.Console.WriteLine("The player score is "+playerScore+" and the computer score is "+computerScore);

             System.Console.WriteLine("Please enter 'r' for rock, 'p' for paper and 's' for scissor");
             string playerChoice = Console.ReadLine().ToLower();

             int enemyChoice = random.Next(0,3);               
            
            if (enemyChoice == 0)
                {
                    System.Console.WriteLine("Enemy chooses rock");
                    switch (playerChoice)
                    {
                       case "r":
                       System.Console.WriteLine("Tie");
                       break;

                       case "p":
                       System.Console.WriteLine("Player wins this round");
                       playerScore++;
                       break;     

                       case "s":
                       System.Console.WriteLine("Computer wins this round");
                       computerScore++;   
                       break;
                       
                       default:
                       System.Console.WriteLine("Invalid input");
                       break;

                
                    }
                }
            
            else if (enemyChoice == 1)
                {
                    System.Console.WriteLine("Enemy chooses paper");

                    switch (playerChoice)
                    {
                       case "r":
                       System.Console.WriteLine("Computer wins this round");
                       computerScore++;
                       break;

                       case "p":
                       System.Console.WriteLine("Tie!");
                       break;     

                       case "s":
                       System.Console.WriteLine("Player wins this round");
                       playerScore++;   
                       break;

                       default:
                       System.Console.WriteLine("Invalid input");
                       break;
                                 
                    }
                }
            else
                {
                    System.Console.WriteLine("Enemy chooses scissors");
                    
                    switch (playerChoice)
                    {
                       case "r":
                       System.Console.WriteLine("Player wins this round");
                       playerScore++;
                       break;

                       case "p":
                       System.Console.WriteLine("Computer wins this round");
                       computerScore++;
                       break;     

                       case "s":
                       System.Console.WriteLine("Tie!");
                       break;

                       default:
                       System.Console.WriteLine("Invalid input");
                       break;
                                 
                    }
                }
            }

             if (playerScore == 3)
                    {
                        System.Console.WriteLine("You win!");
                    }
                    else
                    {
                        System.Console.WriteLine("You lose!");
                    }      
               


                }
                }
}

        
            
        

 
    



