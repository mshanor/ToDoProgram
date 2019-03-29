using System;

/*Program:To-Do List
 * Author: Matthew Shanor 
 * Date: 3-28-2019
 * v:1
 * This program is meant as a familirization with c#. This is a simple program to take in tasks via
 * command line and add them to a list. Each task has a date, priority, and status. User can Add 
 * tasks, date, status, priority. Once a task is completed it is removed from the List.
 */

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variables
            char choice;
            bool entry = false;
            int a;

            //Introduction message to user.
            Console.Write("Welcome to the Task program a console based program. A simple task tracking program.\n");
            Console.Write("This app allows you to add a task to be completed. Set a time limit for each task.\n");
            Console.Write("As well as showing priority and completion status of each task.\n");
            Console.Write("Would you like to continue into the program Yes (Y) or No (N)?");
            
            //check user input to continue or not.
            do
            {
                //read in choice from user
                choice = char.Parse(Console.ReadLine());

                if (choice == 'Y')
                {
                    entry = true;
                }
                else if (choice == 'N')
                {
                    Console.Write("Goodbye.");
                    System.Environment.Exit(0);
                }
                else
                    Console.Write("Invalid entry please enter (Y) or (N)");

            } while (entry == false);

            //provide user with options for how to use program
            Console.Write("Enter (1) to add a task. (2) to show all taks. (3) to complete a task. (4) Exit: ");

            //Create newList for user to start using program
            ToDo newList = new ToDo();

            //loop until user wants to exit
            while (true)
            {
                
                //store users input
                a = int.Parse(Console.ReadLine());
                
                //check which case user inputted and call that procedure in ToDo
                switch (a)
                {
                    case (1):
                        newList.AddTask();
                        Console.Write("Enter another selection: ");
                        break;

                    case (2):
                        newList.ShowList();
                        Console.Write("Enter another selection: ");
                        break;
                    case (3):
                        newList.Complete();
                        Console.Write("Enter another selection: ");
                        break;

                    case (4):
                        Console.WriteLine("GoodBye!");
                        break;

                    default:
                        Console.WriteLine("Invalid entry please input valid option. ");
                        break;

                }
                //condition to break while loop
                if (a == 4)
                {
                    break;
                }
            }
            //pause at end of program
            Console.ReadLine();
        }
    }
}
