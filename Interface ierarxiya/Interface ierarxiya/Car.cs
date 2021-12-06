using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_ierarxiya
{
    class Car : IDoor, IEngine
    {
        public void EngineType(string engine)
        {
            Console.WriteLine("Engine type:" + engine);
        }

        public void HorsePower(int a)
        {
            Console.WriteLine("Horsepower : " + a);
        }
    }
}
