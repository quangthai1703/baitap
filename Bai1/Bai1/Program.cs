using System;

namespace Bai1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates coordinator = new Coordinates();
            coordinator.setX(1);
            coordinator.setY(-1);
            coordinator.setName("X");

            Console.WriteLine(coordinator.getName());
            Console.WriteLine(coordinator.getX());
            Console.WriteLine(coordinator.getY());
            Console.WriteLine(coordinator.ToString());

            Coordinates coordinator2 = new Coordinates(2,3,"Y");
            Console.WriteLine(coordinator2.ToString());
        }
    }
}