using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {

        int[] heights = new int[9];
        // game loop
        while (true)
        {
            for (int i = 0; i < 8; i++)
            {
                heights[i] = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0.
            }

            int maxValue = heights.Max();
            int maxIndex = heights.ToList().IndexOf(maxValue);
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(maxIndex); // The number of the mountain to fire on.
        }
    }
}
