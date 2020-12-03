namespace aoc2020.tobogganing.RoutePlan
{
    public class Course
    {
        public int Right { get; }
        public int Down { get; }
        
        public Course(int right, int down)
        {
            Right = right;
            Down = down;
        }
    }
}