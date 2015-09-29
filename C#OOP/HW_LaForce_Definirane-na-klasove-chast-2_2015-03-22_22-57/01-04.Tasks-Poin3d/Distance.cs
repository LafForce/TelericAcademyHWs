using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04.Tasks_Poin3d
{
    //    Problem 3. Static class
    //Write a static class with a static method to calculate the distance between two points in the 3D space.
    public static class Distance
    {
        public static double CalculateDistance(Point3D firstOne, Point3D secOndne)
        {
            double distance = Math.Sqrt(
                                        ((firstOne.X - secOndne.X) * (firstOne.X - secOndne.X)) +
                                        ((firstOne.Y - secOndne.Y) * (firstOne.Y - secOndne.Y)) +
                                        ((firstOne.Z - secOndne.Z) * (firstOne.Z - secOndne.Z))
                                        );

            return distance;
        }
    }
}
