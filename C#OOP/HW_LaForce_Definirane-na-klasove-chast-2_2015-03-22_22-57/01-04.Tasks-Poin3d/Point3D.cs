namespace _01_04.Tasks_Poin3d
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //    Problem 1. Structure
    //Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
    //Implement the ToString() to enable printing a 3D point.
    public struct Point3D
    {
        //        Problem 2. Static read-only field
        //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        //Add a static property to return the point O.
        private static readonly Point3D O = new Point3D( 0 , 0 , 0 );
        
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D Center
        {
            get { return Point3D.O; }
        }
        
        public override string ToString()
        {
            return String.Format("{{ X = {0}, Y = {1}, Z= {2} }}",
               this.X, this.Y, this.Z);
        }
    }
}
