using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEight
{
    class Program
    {
        static void Main(string[] args)
        {
                StudentInfo();
                Continue();
        }

        public static void StudentInfo()
        {
            string[,] studentInfo = new string[15, 3]
            {
                {"AK", "Detroit", "Pizza"},
                {"Brian", "West Bloomfield", "Pot Roast"},
                {"Evan", "Waterville", "Grilled Octopus"},
                {"Jacky", "Rochester", "Sushi"},
                {"Justin", "Warren", "Quesadillas"},
                {"Kendra", "Oak Park", "Veggie Burger & fries"},
                {"Kent", "Sterling Heights", "Pizza"},
                {"Laura", "Albuquerque", "Steak"},
                {"Levi", "Detroit", "Pizza"},
                {"Mauricio", "Ypsilanti", "Grilled Chicken"},
                {"Noha", "Canada", "Pizza"},
                {"Ronald", "Lincoln Park", "Saganaki"},
                {"Rudy", "Detroit", "Salad"},
                {"Stephen", "Rochester", "Crab Ragoon"},
                {"Steve", "Perrysburg", "Pizza"},
            };

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (Enter a number 0-14):");
            string input = Console.ReadLine();
            int.TryParse(input, out int userInput);
            while (!int.TryParse(input, out userInput) || userInput > 15)
            {
                Console.WriteLine("That student does not exist. Please try again. (Enter a number 0 - 14):");
            }
            if (int.TryParse(input, out userInput) || userInput < 15)
            {
                Console.WriteLine($"Student " + userInput + " is " + studentInfo[userInput, 0]);
            }

            Console.WriteLine("What would you like to know about " + studentInfo[userInput, 0] + "?" + "(enter hometown or favorite food):");
            string fact = Console.ReadLine().ToLower(); ;
            //int.TryParse(fact, out int studentInput);
            while (fact != "hometown" || fact != "favorite food" )
            {
                Console.WriteLine("That is not a valid data type. Please try again:");
                Console.WriteLine("What would you like to know about " + studentInfo[userInput, 0] + "?" + "(enter hometown or favorite food):");
                fact = Console.ReadLine().ToLower();
                //int.TryParse(fact, out studentInput);
            }
            if(fact == "hometown")
            {
                Console.WriteLine(studentInfo[userInput, 0] + " is from " + studentInfo[userInput, 1]);
            }
            else if(fact == "favorite food")
            {
                Console.WriteLine(studentInfo[userInput, 0] + "'s favorite food is " + studentInfo[userInput, 2]);
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to learn about another student? (y/n)");
            string userContinue = Console.ReadLine().ToLower();
            bool run;

            if(userContinue == "y")
            {
                run = true;
            }
            else if (userContinue == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("That is an invalid entry. Please try again: (y/n)");
                run = Continue();
            }
            return run;
        }
    }
}
