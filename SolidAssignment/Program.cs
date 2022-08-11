﻿namespace SolidAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is an Area of shape Calculator\n");
            Console.WriteLine("What shape area do you want to calculate?\n");
            Console.WriteLine("Enter 1 if you want to calculate area of a Square");
            Console.WriteLine("Enter 2 if you want to calculate area of a Rectangle");
            Console.WriteLine("Enter 3 if you want to calculate area of a Rhombus");

            //Try catch block to catch exceptions
            try
            {
                // converting the shape inputed to int
                int shape = Convert.ToInt32(Console.ReadLine());
                // requesting length and breadth of shape from user and converting to float
                Console.WriteLine("What is the length of the shape");
                float Length = float.Parse(Console.ReadLine());
                Console.WriteLine("What is the Breadth of the shape");
                float Breadth = float.Parse(Console.ReadLine());
                {
                    //instantiating define classes
                    var square = new Square();
                    var rectangle = new Rectangle();
                    var rhombus = new Rhombus();
                    // using if else statement to assign the inputted shape number to
                    if (shape == 1)
                    {
                        Console.WriteLine(square.CalculateArea(Length, Breadth));
                    }
                    else if (shape == 2)
                    {
                        Console.WriteLine(rectangle.CalculateArea(Length, Breadth));
                    }
                    else if (shape == 3)
                    {
                        Console.WriteLine(rhombus.CalculateArea( Length, Breadth));
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error has been detected");
                Console.WriteLine(ex.Message);
            }
        }
    }
}