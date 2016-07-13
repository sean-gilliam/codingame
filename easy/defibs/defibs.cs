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
class Solution
{
    static void Main(string[] args)
    {
        Func<string, string> replace = x => x.Replace(",", ".");
        
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());
        
        var longitude = double.Parse(replace(LON));
        var latitude = double.Parse(replace(LAT));
        
        var locations = new List<Location>();
        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            var loc = DEFIB.Split(new[] {';'});
            var location = new Location
            {
                Name = loc[1],
                Street = loc[2],
                Longitude = double.Parse(replace(loc[4])),
                Latitude = double.Parse(replace(loc[5]))
            };
            locations.Add(location);
        }

        Dictionary<double, Location> map = new Dictionary<double, Location>();
        foreach(var ll in locations)
        {
            var distance = Distance(ll.Longitude, ll.Latitude, longitude, latitude);
            map.Add(distance, ll);
        }
        
        var v = map.OrderBy(kvp => kvp.Key).First();
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(v.Value.Name);
    }
    
    static double Distance(double longitudeA, double latitudeA, double longitudeB, double latitudeB)
    {
        double x = (longitudeB - longitudeA) * Math.Cos((latitudeA + latitudeB) / 2);
        double y = latitudeB - latitudeA;
        double d = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2)) * 6371;
        return d;
    }
}

public class Location
{
    public string Name {get; set;}
    public string Street {get;set;}
    public double Longitude {get;set;}
    public double Latitude {get;set;}
}
