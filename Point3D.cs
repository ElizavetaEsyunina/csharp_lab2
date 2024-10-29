using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2__task_1_
{
    internal class Point3D
    {
        private double x;
        private double y;
        private double z;
        
        //конструктор с параметрами
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        //конструктор копирования
        public Point3D(Point3D point)
        {
            x = point.x;
            y = point.y;
            z = point.z;
        }
        //метод, приводящий поля к целому типу
        public void ConvertToInt()
        {
            x = (int)x;
            y = (int)y;
            z = (int)z;
        }

        public override string ToString()
        {
            return $"X: {x} | Y: {y} | Z: {z}";
        }
    }
}
