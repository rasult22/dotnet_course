using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ExceptionsHomeWork();
            Console.ReadLine();
        }

        static void ExceptionsHomeWork() {
            /* 
                Homework: Create a Console Application with a for loop
                that throws an exception after five iterations.
                Catch the exception.
            */
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    if(i == 5)
                    {
                        throw new Exception("Something bad happened ");
                    }
                    Console.WriteLine(i);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"The exception was catched {ex}");
            }
        }
        static void BadCall ()
        {
            int[] ages = new int[] { 1, 2, 3 };
            for (int i = 0; i < ages.Length + 1; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"We had error: {ex.Message}");
                    //throw;
                    throw new Exception("There was an error handling our array", ex);
                }
            }
        }

        static void HandlingExceptions () {
            try
            {
                BadCall();
            } catch (Exception ex)
            {
                Console.WriteLine($"More details for log: {ex} ");
            }
        }

        static void UsingBreakpoints ()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"The value of i is: {i}");
                for (int j = 0; j < 20; j++)
                {
                    Console.WriteLine($"The value of j is: {j}");
                }
            }

        }

        static void HomeWorkLists()
        {
            /* 
                Add student to a class roster until there are no students.
                Then print out the count of the student to the Console
            */

        }

        static void Lists()
        {
            List<string> names = new List<string>();
            names.Add("Tim");
            names.Add("Joe");
            names.Add("Stewart");
            Console.WriteLine($"the second element is { names[1] }");
            names.Remove("Joe");
            Console.WriteLine($"the second element is { names[1] }");
            names[1] = names[1].ToUpper();
            Console.WriteLine($"the second element is { names[1] }");
        }

        static void HomeWorkArrays()
        {
            /*
                Create an array of 3 names
                Ask the user which name to select based on the number in the array
                example: [0] - John  [1] - Joe  [2] - Stewart
            */
            string[] names = new string[] { "CJ", "Dwayne", "Luke" };
            Console.WriteLine("Hello! Please choose name:");
            Console.WriteLine($"[0] - {names[0]}, [1] - {names[1]}, [2] - {names[2]}");
            string indexString = Console.ReadLine();
            bool isValidIndex = int.TryParse(indexString, out int index);
            if(!isValidIndex || index > names.Length - 1 || index < 0)
            {
                Console.WriteLine("Inbvalid input. Please choose one of the following numbers");
                //Console.WriteLine($"[0] - {names[0]}, [1] - {names[1]}, [2] - {names[2]}");
                return;
            }
            Console.WriteLine($"Congrats! You've chose - {names[index]} ");
        }
        static void Arrays ()
        {
            string[] names = new string[5];
            names[0] = "Bob";
            names[1] = "David";
            names[2] = "Carl";
            names[3] = "John";
            names[4] = "Sue";

            string csvNames = "Bob,David,Carl,John,Sue";
            string[] namesFromCSV = csvNames.Split(',');

            int[] numbers = new int[5];
            numbers[0] = 2;

            string[] instantNames = new string[] { "Bob", "David", "Carl", "John", "Sue" };
        }
        static void LoopsHomeWork ()
        {
            string name = "";
            do
            {
                Console.WriteLine("Hello! Whats your name?");
                name = Console.ReadLine();
                if (name.ToLower() == "exit") { return; }
                if (name == "tim")
                {
                    Console.WriteLine("Hello Professor");
                } else
                {
                    Console.WriteLine($"Hello {name}");
                }

            }
            while (name.ToLower() != "tim");
        }
        static void WhileLoop () {
            Console.Write("Whats your age: ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);

            while (!isValidAge)
            {

                Console.Write("Whats your age: ");
                ageText = Console.ReadLine();

                isValidAge = int.TryParse(ageText, out age);
            }
        }
        static void DoWhile () {
            string continueResult = "";

            do {
                Console.Write("What's your name?");
                string name = Console.ReadLine();

                Console.WriteLine($"Hello {name}");

                Console.WriteLine("Do you want to continue? (yes/no)");
                continueResult = Console.ReadLine();
            } while (continueResult.ToLower() != "yes");

        }
        static void MiniProject_1() {

            Console.Write("Hi! Please write your name: ");
            string userName = Console.ReadLine();

            Console.Write("what your age: ");
            string userAge = Console.ReadLine();
            bool isValidAge = int.TryParse(userAge, out int age);

            if(!isValidAge) {
                Console.WriteLine("Invalid age");
                return;
            }

            if (age < 21) {
                Console.WriteLine($"Please wait {21 - age} years to start this class {userName}");
                return;
            }

            if (userName.ToLower() == "bob" || userName.ToLower() == "sue")
            {
                Console.WriteLine($"Welcome professor {userName}");
            } else
            {
                Console.WriteLine($"Hello studet {userName}");
            }

        }
        static void TypeConversion () {
            Console.Write("What is your age: ");
            string ageText = Console.ReadLine();

            // implicit conversion to string
            //ageText += 10;

            // would throw an exception if {ageText} is not valid number
            //int age = int.Parse(ageText);

            bool isValidAge = int.TryParse(ageText, out int age);

            if (isValidAge)
            {
                age += 10;
                Console.WriteLine($"Youre going to be {age} y.o. in 10 years.");
            } else {
                Console.WriteLine("Age is invalid, please type only numbers!");
            }

            Console.WriteLine();
        }
        static void Variables ()
        {
            string firstName = "John";
            string lastName = "Doe";
            // $ - string interpolation
            string fullName = $"{firstName} {lastName}";

            // @ - string literals (treats "\" symbol as character)
            string path = @"C:\temp";

            // $@ combined
            string cv = $@"{ path }\{ firstName }_cv.pdf";


            int age = 0; // All positive and negative integers

            double averageWordsPerMinute = 34.23; // all numbers for fractions with  accuracy ~17 numbers after dot.

            decimal costPerContainer = 43.22M; // big and expensive fraction numbers. Mostly used for money

            bool isActive = false; // true | false

            string zipCode = "00342";


            Console.WriteLine(zipCode);
            Console.WriteLine(cv);
        }
    }
}
