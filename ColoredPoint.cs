using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2__task_1_
{
    class ColoredPoint : Point3D
    {
        private string color;

        //конструктор с параметрами
        public ColoredPoint(double x, double y, double z, string color) : base(x, y, z)
        {
            this.color = color;
        }
        //конструктор копирования
        public ColoredPoint(ColoredPoint point) : base(point)
        {
            color = point.color;
        }
        //метод для изменения цвета точки
        public void ChangeColor(string newColor)
        {
            color = newColor;
        }
        //метод для получения информации о цвете точки
        public string GetColor()
        {
            return color;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Color: {color}";
        }
    }
}
