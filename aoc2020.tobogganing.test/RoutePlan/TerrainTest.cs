using System.IO;
using aoc2020.tobogganing.RoutePlan;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System.Collections.Generic;

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

         [Test]
        public void FindProductOfEncounteredTreesOnPlannedRoutesToBe336()
        {
            var path = Path.Combine("RoutePlan", "TestData", "testInput.txt");
            var courses = new List<Course>(){
                new Course(1, 1),
                new Course(3, 1),
                new Course(5, 1),
                new Course(7, 1),
                new Course(1, 2)
            };
            var terrain = new Terrain(path);
            
            var result = terrain.ProductOfEncounteredTrees(courses);
            
            Assert.That(result, Is.EqualTo(336));
        }
    }
}