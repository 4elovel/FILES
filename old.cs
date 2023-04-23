using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IClone
{
    class mass_sort : IComparer
    {
        public int Compare(object x, object y)
        {
            Tank x1 = x as Tank;
            Tank y1 = y as Tank;
            if (x1.mass > y1.mass)
            {
                return 1;
            }
            if (x1.mass == y1.mass)
            {
                return 0;
            }
            if (x1.mass < y1.mass)
            {
                return -1;
            }
            throw new NotImplementedException();
        }
    }

    class engine_sort : IComparer
    {
        public int Compare(object x, object y)
        {
            Tank x1 = x as Tank;
            Tank y1 = y as Tank;
            if (x1.engine > y1.engine)
            {
                return 1;
            }
            if (x1.engine == y1.engine)
            {
                return 0;
            }
            if (x1.engine < y1.engine)
            {
                return -1;
            }
            throw new NotImplementedException();
        }
    }
    class max_speed_sort : IComparer
    {
        public int Compare(object x, object y)
        {
            Tank x1 = x as Tank;
            Tank y1 = y as Tank;
            if (x1.max_speed > y1.max_speed)
            {
                return 1;
            }
            if (x1.max_speed == y1.max_speed)
            {
                return 0;
            }
            if (x1.max_speed < y1.max_speed)
            {
                return -1;
            }
            throw new NotImplementedException();
        }
    }
    class power_reserve_sort : IComparer
    {
        public int Compare(object x, object y)
        {
            Tank x1 = x as Tank;
            Tank y1 = y as Tank;
            if (x1.power_reserve > y1.power_reserve)
            {
                return 1;
            }
            if (x1.power_reserve == y1.power_reserve)
            {
                return 0;
            }
            if (x1.power_reserve < y1.power_reserve)
            {
                return -1;
            }
            throw new NotImplementedException();
        }
    }
    class fuel_t_sort : IComparer
    {
        public int Compare(object x, object y)
        {
            Tank x1 = x as Tank;
            Tank y1 = y as Tank;
            if (x1.fuel_t > y1.fuel_t)
            {
                return 1;
            }
            if (x1.fuel_t == y1.fuel_t)
            {
                return 0;
            }
            if (x1.fuel_t < y1.fuel_t)
            {
                return -1;
            }
            throw new NotImplementedException();
        }
    }
    class armor_sort : IComparer
    {
        public int Compare(object x, object y)
        {
            Tank x1 = x as Tank;
            Tank y1 = y as Tank;
            if (x1.armor > y1.armor)
            {
                return 1;
            }
            if (x1.armor == y1.armor)
            {
                return 0;
            }
            if (x1.armor < y1.armor)
            {
                return -1;
            }
            throw new NotImplementedException();
        }
    }
    class consumption_sort : IComparer
    {
        public int Compare(object x, object y)
        {
            Tank x1 = x as Tank;
            Tank y1 = y as Tank;
            if (x1.consumption > y1.consumption)
            {
                return 1;
            }
            if (x1.consumption == y1.consumption)
            {
                return 0;
            }
            if (x1.consumption < y1.consumption)
            {
                return -1;
            }
            throw new NotImplementedException();
        }
    }
    class Tank : ICloneable
    {

        public Tank(int mass, int engine, int max_speed, int power_reserve, int fuel_t, int armor, int consumption)
        {
            this.mass = mass;
            this.engine = engine;
            this.max_speed = max_speed;
            this.power_reserve = power_reserve;
            this.fuel_t = fuel_t;
            this.armor = armor;
            this.consumption = consumption;
        }

        public void print()
        {
            Console.WriteLine($"Mass - {mass} kg");
            Console.WriteLine($"Engine power - {engine} hp");
            Console.WriteLine($"Max speed - {max_speed} km");
            Console.WriteLine($"Power reserve - {power_reserve} km");
            Console.WriteLine($"Fuel in tank - {fuel_t} L");
            Console.WriteLine($"Armor - {armor} mm");
            Console.WriteLine($"Consumption - {consumption} L/100km");
            Console.WriteLine("--------------------------------------");
        }

        public object Clone()
        {

            return MemberwiseClone();
        }


        public int mass, engine, max_speed, power_reserve, fuel_t, armor, consumption;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank obj3 = new Tank(1900, 135, 60, 600, 1200, 200, 250);
            Tank T34 = new Tank(1200, 899, 85, 500, 1300, 300, 250);
            Tank obj2 = new Tank(1500, 612, 70, 400, 800, 100, 100);
            Tank[] ls = new Tank[] { obj3, T34, obj2 };
            Console.WriteLine("Write your choice:");
            Console.WriteLine("1 - sort by mass");
            Console.WriteLine("2 - sort by engine power");
            Console.WriteLine("3 - sort by max speed");
            Console.WriteLine("4 - sort by power reserve");
            Console.WriteLine("5 - sort by fuel in tank");
            Console.WriteLine("6 - sort by armor");
            Console.WriteLine("7 - sort by consumption");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Before sort: \n\n");
            for (int i = 0; i < ls.Length; i++)
            {
                ls[i].print();
            }
            switch (choice)
            {
                case 1:
                    Array.Sort(ls, new mass_sort()); break;
                case 2:
                    Array.Sort(ls, new engine_sort()); break;
                case 3:
                    Array.Sort(ls, new max_speed_sort()); break;
                case 4:
                    Array.Sort(ls, new power_reserve_sort()); break;
                case 5:
                    Array.Sort(ls, new fuel_t_sort()); break;
                case 6:
                    Array.Sort(ls, new armor_sort()); break;
                case 7:
                    Array.Sort(ls, new consumption_sort()); break;
                default:
                    Console.WriteLine("Wrong choice");
                    return;
            }

            Console.WriteLine("\n\nAfter sort: \n\n");

            for (int i = 0; i < ls.Length; i++)
            {
                ls[i].print();
            }
            Console.ReadKey();
        }
    }
}
