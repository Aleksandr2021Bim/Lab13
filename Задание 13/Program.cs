using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую инженер \nсмотри параметры здания");
            string a = Convert.ToString(Console.ReadLine());
            double l = Convert.ToDouble(Console.ReadLine());
            double w = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            Building building = new Building(a,l,w,h);
            building.Print();
            double f = Convert.ToDouble(Console.ReadLine());
            MultiBuilding multiBuilding = new MultiBuilding(a, l, w, h, f);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }

    public class Building
    {
        public string Aadress { get; set; } //адрес здания
        public double Length { get; set; } //длина здания
        public double Width { get; set; } //ширина здания
        public double Height { get; set; } //высота здания
        
        public Building(string a, double l, double w, double h)
        {
            Aadress = a;
            Length = l;
            Width = w;
            Height = h;
        }

        public void Print() // метод вывода информации о здании
        {
            Console.WriteLine($"{Aadress} {Length} {Width} {Height}");
        }

    }
    
    public class MultiBuilding : Building
    {
        public double Floor { get; set; } //этажи здания

        public MultiBuilding(string a, double l, double w, double h, double f)
            : base(a, l, w, h)
        {
            Floor = f;
        }

        public void Print()
            {
            base.Print();
            Console.WriteLine($"{Floor}");
            }

      
    }
}
