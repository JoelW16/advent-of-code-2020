using System.Collections.Generic;

namespace aoc2020.elfaccounting
{
    public class ExpenseReport
    {
        private List<int> _expenses;
        public ExpenseReport(List<int> expenses)
        {
            _expenses = expenses;
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
    }
}
