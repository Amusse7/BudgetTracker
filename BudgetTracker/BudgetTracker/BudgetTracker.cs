using System;
using System.Collections.Generic;

class BudgetTracker
{
    private List<Expense> expenses;

    public BudgetTracker()
    {
        expenses = new List<Expense>();
    }

    public void AddExpense(string name, double amount)
    {
        Expense expense = new Expense
        {
            Name = name,
            Amount = amount
        };
        expenses.Add(expense);
        Console.WriteLine("Expense added successfully!");
    }

    public void DisplayExpenses()
    {
        if(expenses.Count == 0)
        {
            Console.WriteLine("No expenses to display.");
            return;
        }

        Console.WriteLine("Expenses:");
        foreach(var expense in expenses)
        {
            Console.WriteLine($"- {expense.Name}: ${expense.Amount}");
        }
    }

    public double CalculateTotalExpenses()
    {
        double total = 0;
        foreach(var expense in expenses)
        {
            total += expense.Amount;
        }

        return total;
    }
}

