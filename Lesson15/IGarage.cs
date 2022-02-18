using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    internal interface IGarage
    {
        public bool AddCar(Car c);
        public void TakeOutCar(Car c);
        public void FixCar(Car c);
    }
}
