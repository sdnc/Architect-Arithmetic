using System;

namespace ArchitectArithmetic
{
  class Program
  {

    public static void Main(string[] args)
    {
        CalculateTotalCost();
    }

    static double CalculateTotalCost()
    {
        float tilePrice;
        int option;
        string currency;

        Console.WriteLine("Welcome to Architect Arithmetic - a program that calculates the total cost of a floor plan depending on the rooms dimensions.");
        Console.WriteLine("What kind of area do you want to calculate? \n 1: A rectangle \n 2: A circle \n 3: A triangle \n 4: The Teotihuacan \n 5: The Taj Mahal \n 6: The Great Mosque of Mecca \n");
        Console.Write("Pick a number: ");
        option = Int32.Parse(Console.ReadLine());
        while (option < 1 || option > 6)
        {
            Console.WriteLine("Sorry, that's not an option. Try again.");
            option = Int32.Parse(Console.ReadLine());
        }
        Console.Write("\nWhat currency are you calculating in? ");
        currency = Console.ReadLine();
        Console.Write("\nWhat's the price per tile? ");
        tilePrice = float.Parse(Console.ReadLine());
        
        if (option == 1) //Rectangle
        {
            Console.Write("\nWhat is the length of the rectangle? ");
            int length = Int32.Parse(Console.ReadLine());
            Console.Write("\nWhat is the rectangle's width? ");
            int width = Int32.Parse(Console.ReadLine());
            double totalArea = Rect(length, width);

            double totalCost = totalArea * tilePrice;
            totalCost = Math.Round(totalCost, 2);

            Console.WriteLine($"\nThe total cost of this floor plan would be {totalCost} {currency}\n");
            return totalArea * tilePrice;

        }
        else if (option == 2) //Circle
        {
            Console.Write("\nWhat is the circles radius? ");
            int radius = Int32.Parse(Console.ReadLine());
            double totalArea = Circle(radius);

            double totalCost = totalArea * tilePrice;
            totalCost = Math.Round(totalCost, 2);

            Console.WriteLine($"\nThe total cost of this floor plan would be {totalCost} {currency}\n");
            return totalCost;

        }
        else if (option == 3) //Triangle
        {
            Console.Write("\nWhat is the width of the triangle's base? ");
            int width = Int32.Parse(Console.ReadLine());
            Console.Write("\nWhat is the triangle's heigth? ");
            int heigth = Int32.Parse(Console.ReadLine());
            double totalArea = Triangle(width, heigth);

            double totalCost = totalArea * tilePrice;
            totalCost = Math.Round(totalCost, 2);

            Console.WriteLine($"\nThe total cost of this floor plan would be {totalCost} {currency}\n");
            return totalCost;

        }
        else if (option == 4) //Teotihuacan
        {
            double totalCost = TeotihuacanTotalArea() * tilePrice;
            totalCost = Math.Round(totalCost, 2);

            Console.WriteLine($"\nThe total cost of a Teotihuacan floor plan would be {totalCost} {currency}\n");
            return totalCost;

        }
        else if (option == 5) //Taj Mahal
        {
            double totalCost = TajMahalTotalArea() * tilePrice;
            totalCost = Math.Round(totalCost, 2);

            Console.WriteLine($"\nThe total cost of a Taj Mahal floor plan plan would be {totalCost} {currency}\n");
            return totalCost;

        }
        else if (option == 6) //Mosque of Mecca
        {
            double totalCost = MeccaTotalArea() * tilePrice;
            totalCost = Math.Round(totalCost, 2);

            Console.WriteLine($"\nThe total cost of a Mecca floor plan would be {totalCost} {currency}\n");
            return totalCost;
        }
        else
        {
            return 0;
        }




    }

    static double TeotihuacanTotalArea()
    {
        /* Teotihuacan, Mexico floor plan */
        double mainFloor = Rect(2500, 1500);
        double circleSideRoom = Circle(375);
        double triangleCorner = Triangle(750, 500);
        return mainFloor + (circleSideRoom / 2) + triangleCorner;
    }

    static double TajMahalTotalArea()
    {
        double baseFloor = Rect(90.5, 90.5);
        double cornerDimensions = Triangle(24, 24);
        return baseFloor - (cornerDimensions * 4); 

    }

    static double MeccaTotalArea()
    {
        double baseFloor = Rect(284, 264);
        double extraRoom = Rect(180, 106);
        double emptySpace = Triangle(264, 84);
        return baseFloor + extraRoom - emptySpace;
    }
    static double Rect(double length, double width)
    {
      return length * width;
    }
    static double Circle(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }
    static double Triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
  }
}
