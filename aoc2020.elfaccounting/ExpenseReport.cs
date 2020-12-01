using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc2020.elfaccounting
{
    public class ExpenseReport
    {
        private List<int> _expenses;
        public ExpenseReport(List<int> expenses)
        {
            _expenses = expenses;
        }
        
        public ExpenseReport(string path)
        {
            _expenses = GetExpenseFromFile(path);
        }

        public int FindProductFor(int year, int numberOfExpenses = 2) {
            if (numberOfExpenses <=1) return 0;            
            foreach (var expense in _expenses)
            {
                int yearDifference = year - expense;
                bool expensesContainDiff = _expenses.Contains(yearDifference);
                if(expensesContainDiff && numberOfExpenses == 2) {
                    return expense * yearDifference;
                }
                else {
                   var product = FindProductFor(yearDifference, numberOfExpenses-1);
                   if (product != 0) {
                       return expense * product;
                   }
                }
            }
            return 0;
        }

        private static List<int> GetExpenseFromFile(string path)
        {
            return File.ReadLines(path).Select(expense => Convert.ToInt32(expense)).ToList();
        }
    }
}