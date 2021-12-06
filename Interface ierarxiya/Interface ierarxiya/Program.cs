using System;

namespace Interface_ierarxiya
{
    class Program
    {
        static void Main(string[] args)
        {
            Car prius = new Car();
            prius.EngineType("Hybrid");
            prius.HorsePower(99);
            IDoor mercedes = new Car();
            mercedes.DoorsLocked("car");
            IDoor plane = new Plane();
            plane.DoorsLocked("plane");
        }
    }
}
