using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_04.Tasks_Poin3d
{
    //Create a static class PathStorage with static methods to save and load paths from a text file.
    //Use a file format of your choice.
    static class PathStorage
    {
        public static void SavePath(Path path, string pathIdentifier)
        {
            using (StreamWriter pathWriter = new StreamWriter("..//..//path" + pathIdentifier + ".txt"))
            {
                for (int i = 0; i < path.PathStorage.Count; i++)
                {
                    pathWriter.WriteLine(path.PathStorage[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            string regex = @"X: (?<x>-?\d*\.?\d+([eE][-+]?\d+)?); Y: (?<y>-?\d*\.?\d+([eE][-+]?\d+)?); Z: (?<z>-?\d*\.?\d+([eE][-+]?\d+)?)";
            Path path = new Path();
            StreamReader reader = new StreamReader(filePath, Encoding.UTF8);

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    Match match = Regex.Match(reader.ReadLine(), regex);
                    double x = double.Parse(match.Groups["x"].Value);
                    double y = double.Parse(match.Groups["y"].Value);
                    double z = double.Parse(match.Groups["z"].Value);
                    Point3D point = new Point3D(x, y, z);
                    path.AddPoint(point);
                }
            }

            return path;
        }
    }
}
