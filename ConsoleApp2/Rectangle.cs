using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте класс «прямоугольник» (Rectangle) в отдельном файле (Rectangle.cs). Поля класса –
//высота и ширина (private). Методы класса должны вычислять площадь и периметр.
//Создайте конструкторы: пустой(определяет значения по умолчанию) и с параметрами. В
//случае передачи в конструктор с параметрами некорректных данных, устанавливать значение по
//умолчанию.
//С помощью метода деконструкции организовать декомпозицию объекта класса на его
//ширину и высоту. То есть получить ширину и высоту из объекта должно быть можно только через
//декомпозицию.


namespace ConsoleApp2
{
    internal class Rectangle
    {
        private int height;
        private int width;

        public Rectangle() //по умолчанию
        {
            height = 0;
            width = 0;
        }

        public Rectangle(int height, int width) //с параметрами
        {
            this.height = height;
            this.width = width;
        }

        public void Deconstruct(out int width, out int height) //деконструктор
        {
            width = this.width;
            height = this.height;
        }

        public int Square() //площадь
        {
            return width * height;
        }

        public int Perimeter() //периметр
        {
            return (width + height) * 2;
        }
    }
}
