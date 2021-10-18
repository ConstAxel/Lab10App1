using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
            //    Реализовать класс, в котором указанные значения представлены в виде свойств.Для свойств предусмотреть проверку корректности данных.
            //    Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. 
            //    Создать объект на основе разработанного класса. Осуществить использование объекта в программе.
            Console.WriteLine("Программа перевода данных угла из градусов в радианы!!!");
            Console.WriteLine("Введите значения:");
            Console.Write("Значение градусов:\t");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Значение минут: \t");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Значение секунд:\t");
            int sec = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(gradus, min, sec);
            angle.AngleOut();
            angle.Radians();

            Console.ReadKey();
        }
    }
    class Angle
    {
        private int gradus;
        private int min;
        private int sec;
        public int Gradus
        {
            set
            {
                if (value >= 0 && value < 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение градусов введено неверно");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение минут введено неверно");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение секунд введено неверно");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;

        }
        public void AngleOut()
        {
            Console.WriteLine($"Значения угла: {Gradus} (град):{Min} (мин):{Sec} (сек)");

        }
        public void Radians()
        {
            double Rad = ((Gradus * Math.PI) / 180) + ((Min * Math.PI) / (60 * 180)) + ((Sec * Math.PI) / (180 * 3600));
            Console.WriteLine($"Значения угла в радианах: {Rad:f2}");
        }




    }
}
