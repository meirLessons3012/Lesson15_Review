using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    internal class Car
    {
        public CarTypes Brand { get; set; }
        //field: brand<K>_backingField
        //get_method: get
        //set_method: set
        public bool IsTotalLost { get; set; }
        public bool IsNeedRepair { get; set; }

        public Car(CarTypes brand, bool isTotalLost, bool isNeedRepair)
        {
            if (isTotalLost && !isNeedRepair)
                throw new RepairMismatchException();

            Brand = brand;
            IsTotalLost = isTotalLost;
            IsNeedRepair = isNeedRepair;


        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this,Formatting.None);
        }
    }
}
