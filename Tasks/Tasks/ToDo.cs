using System;
using System.Collections.Generic;


namespace Tasks
{
    class ToDo
    {
        //Class Variables
        private string task { get; set;}
        private DateTime date{get;set;}
        private string priority { get; set; }
        //Input variables from user
        public string a;
        public DateTime b;
        public string c;

        //default constructor
        public ToDo()
        {
            
        }

        //constructor
        public ToDo(string _name, DateTime _date, string _priority)
        {
            task = _name; //task variable initialized to user input
            date = _date; //date variable intialized to user input
            priority = _priority; //priority variable initialized to user input
        }
        //setup new list for todo tasks
        public List<ToDo> myList = new List<ToDo>();

        //User has chosen to add tasks to their list.
        public void AddTask()
        {
            Console.Write("Enter task: ");
            a = Console.ReadLine();

            Console.Write("Please enter due date in this format yyyy-mm-dd: ");
            b = DateTime.Parse(Console.ReadLine());

            Console.Write("What is the Priority High, Mid, Low: ");
            c = Console.ReadLine();

            //create ToDo instance tasks to add to list.
            ToDo tasks = new ToDo( a, b, c);

            //add to list tracking tasks
            myList.Add(tasks);    

        }


        //method to display all current tasks and their priorities
       public void ShowList()
        {
            //Task ID variable
            int i = 0;
            //loop through list 
            foreach (ToDo element in myList)
            {
                //Print to conosle task ID/Task/Date/Priority
                Console.WriteLine($"{i}" + " - " + element.task + ", " + element.date.ToShortDateString() + ", " + element.priority);
                //increment ID
                i++;
            }
        }

        //method to remove completed tasks from each list
        public void Complete()
        {
            //Check if list is empty signal user if so. Otherwise find completed task and remove from list.
            if (myList.Count != 0)
            {
                int z;
                Console.Write("Which task is complete?: ");
                z = int.Parse(Console.ReadLine());
                myList.RemoveAt(z);
            }
            else
                Console.WriteLine("No current tasks available.");
        }
    }
}
