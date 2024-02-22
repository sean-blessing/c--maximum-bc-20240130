using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarProject {
    internal class Car {
        public int CarID { get; set; }
        public string CarDescription { get; set; }
        public string CarType { get; set; }

        public decimal Price { get; set; } = 30000;

        public int Wheels { get; set; }

        public int Doors { get; set; }

        public double TrunkSpace { get; set; }

        public string PowerType { get; set; }


        public Car() {    
        }

        public Car(int carID, string carDescription, string carType, decimal price, int wheels, int doors, double trunkSpace, string powerType) {
            CarID = carID;
            CarDescription = carDescription;
            CarType = carType;
            Price = price;
            Wheels = wheels;
            Doors = doors;
            TrunkSpace = trunkSpace;
            PowerType = powerType;
        }

        
        public override string? ToString() {
            return $"carID: {CarID}, carDescription: {CarDescription}";
        }

    }
}
