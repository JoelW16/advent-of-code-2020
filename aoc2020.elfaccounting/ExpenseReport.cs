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

        public int FindProductFor(int year) {
            foreach (var expense in _expenses)
            {
                int yearDifference = year - expense;
                bool expensesContainDiff = _expenses.Contains(yearDifference);
                if(expensesContainDiff) {
                    return expense * yearDifference;
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
