using System.IO;
using aoc2020.tobogganing.RoutePlan;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;

namespace aoc2020.tobogganing.test.RoutePlan
{
    public class TerrainTest
    {
        [Test]
        public void Encounters7TreesOnPlannedRoute()
        {
            var path = Path.Combine("RoutePlan", "TestData", "testInput.txt");
            var course = new Course(3, 1);
            var terrain = new Terrain(path);
            
            var result = terrain.EncounteredTreesCount(course);
            
            Assert.That(result, Is.EqualTo(7));
        }
    }
}