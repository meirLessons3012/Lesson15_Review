using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    internal class Garage : IGarage
    {
        private int counter;
        private Car[] privateCars;
        public Car[] Cars 
        { 
            get 
            { 
                return privateCars;
            }
            private set 
            { 
                privateCars = value;
            } 
        }
        public CarTypes[] CarTypes { get;}

        public Garage(CarTypes[] carTypes)
        {
            CarTypes = carTypes;
            Cars = new Car[20];
        }

        public bool AddCar(Car c)
        {
            if (c == null)
                throw new CarNullException("Car Null Exception");
            if (!CarTypes.Contains(c.Brand))
                throw new WrongGarageException("Wrong Garage Exception");
            if (Cars.Contains(c))
                throw new CarAlreadyHereException("Car Already Here Exception. ");
            if (c.IsTotalLost)
                throw new WeDoNotFixTotalLostException("We Do Not Fix Total Lost Exception. ");
            if (!c.IsNeedRepair)
                throw new RepairMismatchException("Repair Mismatch Exception");

            Cars[counter++] = c;
            return true;
        }

        public void FixCar(Car c)
        {
            if (c == null)
                throw new NullReferenceException();
            if (!c.IsNeedRepair)
                throw new RepairMismatchRepairException();

            c.IsNeedRepair = false;
        }

        public void TakeOutCar(Car c)
        {
            if (c == null)
                throw new CarNullException("Car Null Exception");
            if (!Cars.Contains(c))
                throw new CarNotInGarageException();
            if (c.IsNeedRepair)
                throw new CarNotReadyException();

            int index = Array.IndexOf(Cars, c);//3
            Cars[index] = null;//c1 c2 c3 c5 c6 c7 c8 c9 c10 null
            for (int i = index; i < Cars.Length - 1; i++)
            {
                Cars[i] = Cars[i + 1];
                Cars[i + 1] = null;
            }
            counter--;
        }
    }
}
