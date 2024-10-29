using Laba2__task_1_;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Лабораторная работа №2. Задание 1\n");
        Console.WriteLine("Введите координаты X, Y и Z точки в трехмерном пространстве");
        if (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y) && double.TryParse(Console.ReadLine(), out double z))
        {
            //тестирование конструкторов и методов базового класса
            Console.WriteLine();
            Console.WriteLine("1) Тестирование конструкторов и методов базового класса");

            Point3D new_point = new Point3D(x, y, z);
            Point3D copy_point = new Point3D(new_point);
            Console.WriteLine("Тестирование конструктора с параметрами: " + new_point);
            Console.WriteLine("Тестирование конструктора копирования: " + copy_point);

            new_point.ConvertToInt();
            Console.WriteLine("Тестирование метода, приводящего поля к целому типу: " + new_point);

            Console.WriteLine();

            //тестирование конструкторов и методов дочернего класса
            Console.WriteLine("2) Тестирование конструкторов и методов дочернего класса");
            Console.WriteLine("Введите цвет точки");
            string color = Console.ReadLine();
            ColoredPoint colored_point = new ColoredPoint(x, y, z, color);
            ColoredPoint copy_cp = new ColoredPoint(colored_point);
            Console.WriteLine("Тестирование конструктора с параметрами: " + colored_point);
            Console.WriteLine("Тестирование конструктора копирования: " + copy_cp);
            Console.WriteLine("Тестирование метода получения информации о цвете точки: " + colored_point.GetColor() + "\n");

            Console.WriteLine("Давайте поменяем цвет этой точки. Введите новый цвет точки");
            string new_color = Console.ReadLine();
            colored_point.ChangeColor(new_color);
            Console.WriteLine("Тестирование метода изменения цвета точки: " + colored_point);
            Console.WriteLine("Тестирование метода получения информации о цвете точки: " + colored_point.GetColor());
        }
        else Console.WriteLine("Некорректный формат входных данных");
    }
}