namespace ShapeAreaCalculator
{

class Program
   {
    public static void Main (string[]args)
        {
        System.Console.WriteLine("Hello! welcome to the area calculator");
        System.Console.WriteLine("Here you can calculate the area of your selected shape");

        System.Console.WriteLine("Enter 'r' for rectangle");
        System.Console.WriteLine("Enter 's' for square");
        System.Console.WriteLine("Enter 'c' for circle");
    
        string selectedShape = Console.ReadLine().ToLower();
        
        
        if (selectedShape == "r")
            {
               System.Console.WriteLine("Please enter the length of the rectangle");
               double length = Convert.ToDouble(Console.ReadLine());
               System.Console.WriteLine("Please enter the breadth of the rectangle");
               double breadth = Convert.ToDouble(Console.ReadLine());

               System.Console.WriteLine("The area of the rectangle is "+length*breadth);
            }
        else if(selectedShape == "s")
            {
               System.Console.WriteLine("Please enter the length of the square");
               double sqLeangth = Convert.ToDouble(Console.ReadLine());
               System.Console.WriteLine("The area of the square is "+sqLeangth*sqLeangth); 
            
            }
        else if(selectedShape == "c")
            {
                System.Console.WriteLine("Please enter the radius of the circle");
                double radius= Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("The area of the circle is "+Math.PI*radius*radius);

            }
            else
            {
                System.Console.WriteLine("Invalid user input");
            }    
        System.Console.WriteLine("Thank you for using this application");

        }

   }
}