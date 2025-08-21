using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
   interface Vehicles
    {
        void Start();
        void Stop();
        int GetSpeed();
    }

    class Car : Vehicles
    {
        private int Speed;
        public void Start()
        {
            Speed = 40;
            Console.WriteLine("Car Stopped = " + Speed + " Km/h");
        }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Car stopped.");
        }

        public int GetSpeed()
        {
            return Speed;
        }
    }

    class Bike : Vehicles
    {
        private int speed;

        public void Start()
        {
            speed = 20;
            Console.WriteLine("Bike started. Speed = " + speed + " km/h");
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine("Bike stopped.");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }


    class Disp1
    {
        public static void disp1()
        {
            Vehicles car = new Car();
            car.Start();
            Console.WriteLine("Car Speed: " + car.GetSpeed());
            car.Stop();

            Console.WriteLine();

            Vehicles bike = new Bike();
            bike.Start();
            Console.WriteLine("Bike Speed: " + bike.GetSpeed());
            bike.Stop();

        }
    }
}
