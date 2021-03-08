using System;

namespace MultiInterfaceApp
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아!");
        }

        public void Run()
        {
            Console.WriteLine("달려!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar dreamCar = new DroneCar();
            dreamCar.Run();
            dreamCar.Fly();

            Console.WriteLine("자동차로 변경 (interface)");
            IRunnable car = dreamCar;
            car.Run();
            // car.Fly(); error 

            IFlyable plane = dreamCar;
            plane.Fly();
        }
    }
}
