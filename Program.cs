using System;
using Microsoft.VisualBasic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////task1
            // Point point = new Point();
            // Point point2 = new Point(10, 20);
            // point.ShowData();
            // point2.ShowData();

            ////task2
            // Counter c = new Counter(0, 10);
            // System.Console.WriteLine(c.GetCurrent());
            // c.Increment();
            // c.Increment();
            // c.Increment();
            // c.Increment();
            // c.Increment();
            // System.Console.WriteLine(c.GetCurrent());c.Increment();
            // System.Console.WriteLine(c.GetCurrent());c.Increment();
            // System.Console.WriteLine(c.GetCurrent());c.Increment();
            // System.Console.WriteLine(c.GetCurrent());c.Increment();
            // System.Console.WriteLine(c.GetCurrent());c.Increment();
            // System.Console.WriteLine(c.GetCurrent());c.Increment();
            // System.Console.WriteLine(c.GetCurrent());
        }
    }

    #region task1
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void ShowData()
        {
            System.Console.WriteLine($"X = {X}\nY = {Y}");
        }

    }
    #endregion

    #region task2
    struct Counter
    {
        public int min { get; set; }
        public int max { get; set; }
        public int current { get; set; }
        public Counter()
        {
            min = 0;
            current = 0;
            max = 100;
        }
        public Counter(int Min, int Max)
        {
            min = Min;
            current = min;
            max = Max;
        }
        public void Increment()
        {
            if (current != max)
                current++;
            else
                current = min;
        }
        public int GetCurrent()
        {
            return current;
        }
    }
    #endregion
}