using System.Data;

namespace ToDoList
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello! welcome to the to-do list application");

            List <string> taskList = new List<string>();

            string userInput = "";
            

            while (userInput != "e")
            {
            System.Console.WriteLine("Please enter 1 to add tasks");
            System.Console.WriteLine("Please enter 2 to remove a task from the list");
            System.Console.WriteLine("Please enter 3 to view the list of tasks");
            System.Console.WriteLine("Please enter 'e' to exit from the program");

            userInput = Console.ReadLine().ToLower();

            if(userInput == "1")
                {
                    System.Console.WriteLine("Please enter the task you would like to enter");
                    string enteredTask = Console.ReadLine();

                    taskList.Add(enteredTask);
                    System.Console.WriteLine("The task was successfully added");

                }
            else if(userInput == "2")
                {
                    for (int i = 0; i< taskList.Count; i++)
                    {
                         System.Console.WriteLine(i+": " + taskList[i]);
                    }
                    System.Console.WriteLine("Please enter the number of the task that you want to remove from the list");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);

                    System.Console.WriteLine("You have successfully removed "+taskNumber+" numbered tack");
                    
                }    
            else if(userInput == "3")
                {
                    System.Console.WriteLine("Current tasks in the list : ");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        System.Console.WriteLine(taskList[i]);
                    }

                }   
            else if (userInput == "e")
                {
                    System.Console.WriteLine("Exiting program.....");
                }
                else
                {
                    System.Console.WriteLine("Invalid option entered, please try again");
                }    
            }

         System.Console.WriteLine("Tnank you for using the application");   

        }
    }
}