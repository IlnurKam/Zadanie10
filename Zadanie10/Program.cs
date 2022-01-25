using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Homework10
{
    class Ugol
    {
        int grade = Grade;
        public int minutes = Minutes;
        private int seconds = Seconds;

        public static int Grade { get; private set; }
        public static int Minutes { get; private set; }
        public static int Seconds { get; private set; }

        public void Radian()
        {
            Console.WriteLine("Введите количество градусов угла");
            double Grade = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество минут угла");
            double Minutes = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество секунд угла");
            double Seconds = double.Parse(Console.ReadLine());
            var Radians = (Grade + Minutes / 60 + Seconds / 3600) * (Math.PI) / 180;
            if (Grade < 0)
                Radians = -Radians;
            Console.WriteLine("Значение данного угла в радианах=" + Radians);
        }

        public void PrintUgol()
        {
            Radian();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ugol ugol = new Ugol();
            ugol.PrintUgol();
        }
    }
}