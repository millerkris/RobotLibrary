using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotLibrary
{
    public class Robot
    {
        private (int, int) coord;
        private string route;
        private string name;


        public Robot() { }

        public Robot(int x, int y, string n)
        {
            coord.Item1 = x;
            coord.Item2 = y;
            name = n;
        }

        public void Move()
        {
            Random random = new Random();
            int rnd = random.Next(0, 4);

            switch (rnd)
            {
                case 0: route = "Вперед";
                    coord.Item2 += 1;
                    break;
                case 1: route = "Назад";
                    coord.Item2 -= 1;   
                    break;
                case 2: route = "Налево";
                    coord.Item1 -= 1;
                    break;
                case 3: route = "Направо";
                    coord.Item1 += 1;
                    break;
            }

        }

        public void GetInfo()
        {
            if (route == null) return;
            Console.WriteLine(name + " " + route + " " + coord.ToString());
        }

        public override string ToString()
        {
            return $"({ coord.Item1} , { coord.Item2}) ";
        }
    }
}
