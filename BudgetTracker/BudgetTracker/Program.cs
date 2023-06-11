using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        BudgetTracker budgetTracker = new BudgetTracker();

        while(true)
        {
            Console.WriteLine("Budget Tracker");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. Display Expenses");
            Console.WriteLine("3. Calculate Total Expenses");
            Console.WriteLine("4. Exit");
            Console.WriteLine("-----------------------------");
            Console.Write("Enter Your Choice: ");

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.Write("Enter expense name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter expense amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    budgetTracker.AddExpense(name, amount);
                    break;

                case "2":
                    budgetTracker.DisplayExpenses();
                    break;
                case "3":
                    double totalExpenses = budgetTracker.CalculateTotalExpenses();
                    Console.WriteLine($"Total expenses: ${totalExpenses}");
                    break;
                case "4":
                    Console.WriteLine("Exiting the program..");
                    return;
                default:
                    Console.WriteLine("Invalid Input. Please Try Again!");
                    break;
            }

            Console.WriteLine();
        }
    }
}