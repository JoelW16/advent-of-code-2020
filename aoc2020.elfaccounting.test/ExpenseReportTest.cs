using NUnit.Framework;
using System.Collections.Generic;

namespace aoc2020.elfaccounting.test
{
    public class ExpenseReportTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FindProductForX()
        {
            // Arrange
            var expenseReportInput = new List<int> {
                1721,
                979,
                366,
                299,
                675,
                1456
            };
            var expectedProduct = 514579;
            var expenseReport = new ExpenseReport(expenseReportInput);
            // Act
            var result = expenseReport.FindProductFor(2020);
            // Assert
            Assert.That(result, Is.EqualTo(expectedProduct));
        }
    }
}