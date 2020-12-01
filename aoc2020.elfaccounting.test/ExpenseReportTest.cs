using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace aoc2020.elfaccounting.test
{
    public class ExpenseReportTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FindProductFromList()
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

            [Test]
        public void FindProductFromNExpensesList()
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
            var expectedProduct = 241861950;
            var expenseReport = new ExpenseReport(expenseReportInput);
            // Act
            var result = expenseReport.FindProductFor(2020, 3);
            // Assert
            Assert.That(result, Is.EqualTo(expectedProduct));
        }
        
        
        [Test]
        public void FindProductFromFile()
        {
            // Arrange
            var path = Path.Combine("TestData", "input.txt");
            var expenseReport = new ExpenseReport(path);
            // Act
            var result = expenseReport.FindProductFor(2020);
            // Assert
            Assert.That(result, Is.Positive);
            Console.WriteLine($"Product is: {result}");
        }

        [Test]
        public void FindProductFromNFiles()
        {
            // Arrange
            var path = Path.Combine("TestData", "input.txt");
            var expenseReport = new ExpenseReport(path);
            // Act
            var result = expenseReport.FindProductFor(2020, 3);
            // Assert
            Assert.That(result, Is.Positive);
            Console.WriteLine($"Product is: {result}");
        }
    }
}