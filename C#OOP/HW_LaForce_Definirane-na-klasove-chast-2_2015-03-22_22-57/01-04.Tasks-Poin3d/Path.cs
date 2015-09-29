using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04.Tasks_Poin3d
{
    //    Problem 4. Path
    //Create a class Path to hold a sequence of points in the 3D space.
    
    class Path
    {
        private List<Point3D> pathStorage;

        public List<Point3D> PathStorage
        {
            get { return this.pathStorage; }
            private set { this.pathStorage = value; }
        }

        public Path()
        {
            this.PathStorage = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.pathStorage.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.pathStorage.Remove(point);
        }
    }
}
