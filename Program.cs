using System;

namespace CircleTest
{
    /// <summary>
    /// Класс, представляющий окружность
    /// </summary>
    class Circle
    {   /// <summary>
        /// Координаты центра окружности и радиус
        /// </summary>
        public double x, y, r;

        /// <summary>
        /// Название объекта
        /// </summary>

        public string Name;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Circle() : this(0, 0, 0) { }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="_x">Координата x центра окружности</param>
        /// <param name="_y">Координата y центра окружности</param>
        /// <param name="_r">Радиус окружности</param>
        /// Картинка Бургера для примера:
        /// </summary>
        /// <img src="D:\Programmirovanie)\Politekh IVT-12\3-kyrs_6-semestr\test_lab3\CircleTest\bin\Debug\netcoreapp3.1\burger.png" alt="Interval" width="400" height="300" />

        public Circle(double _x, double _y, double _r)
        {
            x = _x;
            y = _y;
            r = _r;
        }

        /// <summary>
        /// Метод инициализации окружности с новыми значениями
        /// </summary>
        /// <param name="_x">Координата x центра окружности</param>
        /// <param name="_y">Координата y центра окружности</param>
        /// <param name="_r">Радиус окружности</param>
        public void Init(double _x, double _y, double _r)
        {
            x = _x;
            y = _y;
            r = _r;
        }

        /// <summary>
        /// Метод чтения значений для окружности с консоли
        /// </summary>
        public void Read()
        {
            Console.Write("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите r: ");
            r = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Метод вывода информации об окружности
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"x = {x}, y = {y}, r = {r}");
        }

        /// <summary>
        /// Метод вычисления расстояния от центра окружности до начала координат
        /// </summary>
        /// <returns>Расстояние до начала координат</returns>
        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }

        /// <summary>
        /// Виртуальный Метод присваивания значений окружности для цилиндра.
        /// Присваивает значения координат и радиуса текущему цилиндру из другой окружности.
        /// </summary>
        /// <param name="c">Окружность, значения которой будут присвоены цилиндру.</param>
        public virtual void Assign(Circle c)
        {
            x = c.x; // Присваивание координаты x текущей окружности из другой окружности.
            y = c.y; // Присваивание координаты y текущей окружности из другой окружности.
            r = c.r; // Присваивание радиуса текущей окружности из другой окружности.
        }

        /// <summary>
        /// Статический метод для сложения двух окружностей
        /// </summary>
        /// <param name="c">Первая окружность</param>
        /// <param name="c1">Вторая окружность</param>
        /// <returns>Результат сложения</returns>

        public static Circle Add(Circle c, Circle c1)
        {
            Circle res = new Circle();
            res.r = c.r + c1.r;
            res.x = (c.x + c1.x) / 2;
            res.y = (c.y + c1.y) / 2;
            return res;
        }
    }

    /// <summary>
    /// Класс, представляющий цилиндр
    /// </summary>
    class Cylinder : Circle
    {
        /// <summary>
        /// Дополнительное поле - высота цилиндра
        /// </summary>
        private double z;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Cylinder() : this(0, 0, 0, 0) { }
        /// <summary>
        /// Конструктор с параметрами
        /// <summary>
        /// <param name="_x">Координата x центра окружности</param>
        /// <param name="_y">Координата y центра окружности</param>
        /// <param name="_r">Радиус окружности</param>
        /// <param name="_z">Высота цилиндра</param>
        public Cylinder(double _x, double _y, double _r, double _z) : base(_x, _y, _r)
        {
            Init(_x, _y, _r);
            z = _z;
        }

        /// <summary>
        /// Метод установки значения высоты цилиндра
        /// </summary>
        /// <param name="_z">Высота цилиндра</param>
        public void Put(double _z)
        {
            z = _z;
        }

        /// <summary>
        /// Метод получения значения высоты цилиндра
        /// </summary>
        /// <returns>Высота цилиндра</returns>
        public double Get()
        {
            return z;
        }

        /// <summary>
        /// Переопределение метода инициализации для цилиндра
        /// </summary>
        /// <param name="_x">Координата x центра окружности</param>
        /// <param name="_y">Координата y центра окружности</param>
        /// <param name="_r">Радиус окружности</param>
        /// <param name="_z">Высота цилиндра</param>
        public void Init(double _x, double _y, double _r, double _z)
        {
            base.Init(_x, _y, _r); // Вызов метода инициализации базового класса
            z = _z;
        }

        /// <summary>
        /// Переопределение метода отображения информации о цилиндре
        /// </summary>
        public new void Display()
        {
            base.Display(); // Вызов метода отображения базового класса
            Console.WriteLine($"z = {z}");
        }

        /// <summary>
        /// Переопределение метода присваивания значений окружности для цилиндра
        /// </summary>
        /// <param name="c">Окружность, значения которой будут присвоены цилиндру</param>
        public override void Assign(Circle c)
        {
            base.Assign(c); // Вызов метода присваивания базового класса
            z = r / 2; // Высота цилиндра равна половине радиуса окружности
        }
    }

    /// <summary>
    /// Основной класс программы
    /// </summary>
    /// Формулы площади круга: 
    /// \f[
    /// S = (pi*r)^2
    /// \f]
    /// Длины окружности и диаметр:
    /// \f[
    /// С = π∗D
    /// \f]
    /// Длина окружности:
    /// \f[
    /// C=2∗π∗R
    /// \f]
    /// Уравнение окружности:
    /// \f[
    /// r^2=x^2+y^2
    /// \f]
    /// <remarks>
    /// Этот класс содержит точку входа в программу и демонстрирует
    /// использование классов Circle и Cylinder для работы с окружностями 
    /// </remarks>

    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        static void Main()
        {
            Circle c = new Circle(); // Создание окружности
            Circle c2 = new Circle(); // Создание второй окружности
            Circle c3 = new Circle(); // Создание третьей окружности
            Circle c1 = new Circle(); // Создание четвертой окружности

            Console.WriteLine("Название объекта: Окружности");

            Console.WriteLine("Введите параметры для окружности 1: ");
            c1.Read();

            Console.WriteLine("Введите параметры для окружности 2: ");
            c2.Read();

            c3 = Circle.Add(c2, c1); // Сложение двух окружностей

            Console.WriteLine("Расстояние от центра окружности 1 до начала координат: " + c1.Distance());
            Console.WriteLine("Расстояние от центра окружности 2 до начала координат: " + c2.Distance());
            Console.WriteLine("Сумма окружностей 1 и 2: ");
            c3.Display(); // Отображение результатов сложение окружностей
                          // Создаем объекты базового и производного классов
            Circle c0 = new Circle(); // Создание объекта окружности
            Cylinder cylinder = new Cylinder(1.0, 2.0, 3.0, 4.0); // Создание объекта цилиндра

            // Инициализируем объект базового класса
            c0.Init(1.0, 2.0, 3.0);

            // Присваиваем объекту производного класса объект базового класса
            cylinder.Assign(c0);

            // Выводим информацию о цилиндре
            cylinder.Display();

            // Демонстрируем работу с методами Get и Put для поля z
            Console.WriteLine($"Значение поля z: {cylinder.Get()}");
            cylinder.Put(5.0);
            Console.WriteLine($"Новое значение поля z: {cylinder.Get()}");

        }
    }
}

    