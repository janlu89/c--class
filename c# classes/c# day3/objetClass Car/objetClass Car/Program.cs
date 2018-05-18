using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetClass_Car
{
    class Car
    {
        public int numberOfSit;
        public string model;
        public string engine;
        public decimal mileage;
        public int enginePwr;
        public int year;
        public decimal price;

        public static int numberOfModels;
        public static int wheels;
        public static string factory;
        public static int totalCarSold;
        public static decimal valueOfStock;
    }



    class Program
    {
        static void Main(string[] args)
        {

            //initialization of general cars feature
            Car.numberOfModels = 0;
            Car.wheels = 4;
            Car.factory = "Ford";
            Car.totalCarSold = 0;
            Car.valueOfStock = 10000000;

            //initializiation of individual car feature
            Car car1 = new Car();

            car1.numberOfSit = 7;
            car1.model = "kuga";
            car1.engine = "diesel";
            car1.mileage = 0;
            car1.enginePwr = 120;
            car1.year = 2017;
            car1.price = 30000;
            Car.numberOfModels++; //increase the numbers of objects data

            Car car2 = new Car();

            car2.numberOfSit = 4;
            car2.model = "Fiesta";
            car2.engine = "eletric";
            car2.mileage = 10000;
            car2.enginePwr = 40;
            car2.year = 2016;
            car2.price = 25000;
            Car.numberOfModels++;

            Car car3 = new Car();

            car3.numberOfSit = 2;
            car3.model = "Smart";
            car3.engine = "eletric";
            car3.mileage = 0;
            car3.enginePwr = 30;
            car3.year = 2018;
            car3.price = 15000;
            Car.numberOfModels++;

            Console.WriteLine("Car Factory:{7} \n wheels:{8} \n  Model:{0} \n Engine:{1} \n Sit:{2} \n Engine Power:{3} \n Year:{4} \n Mileage{5} \n Price{6}£", car1.model,car1.engine,
                                car1.numberOfSit,car1.enginePwr,car1.year,car1.mileage,car1.price,Car.factory,Car.wheels);
            Console.WriteLine("Number of model: "+Car.numberOfModels);
        }
    }
}
