using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace aoc2020.tobogganing.RoutePlan
{
    public class Terrain
    {
        private readonly char[][] _terrain;
        private readonly int _terrainHeight;
        private readonly int _terrainWidth;
        public Terrain(string path)
        {
            _terrain = GetTerrainFromFile(path);
            _terrainHeight = _terrain.Length;
            _terrainWidth =_terrain[_terrainHeight-1].Length;
        }

        public int EncounteredTreesCount(Course course)
        {
            var encounteredTrees = 0;
            
            var latitude = TraverseLatitude(0,0);
            for (var longitude = 0; longitude < _terrainHeight; longitude += course.Down)
            {
                if(_terrain[longitude][latitude].Equals('#')) encounteredTrees++;
                latitude = TraverseLatitude(latitude, course.Right);
            }
            return encounteredTrees;
        }

        public int ProductOfEncounteredTrees(List<Course> courses)
        {
            if (courses.Count == 0) {
                return 0;
            }
            var ProductOfEncounteredTrees = 1;

            foreach (var course in courses)
            {
                ProductOfEncounteredTrees *= EncounteredTreesCount(course);
            }
            return ProductOfEncounteredTrees;
        }

        private int TraverseLatitude(int latitude, int traversal)
        {
            return (latitude + traversal) % _terrainWidth;
        }
        
        private static char[][] GetTerrainFromFile(string path)
        {
            return File.ReadLines(path)
                .Select(lon => lon
                    .Select(lat => lat)
                    .ToArray())
                .ToArray();
        }
    }
}