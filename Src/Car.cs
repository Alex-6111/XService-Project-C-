using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XService.Src
{
    public class Car
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? VIN { get; set; }
        public string? StateNumber { get; set; }
        public bool IsRepair = false;

        public Car(int? id, string? name, string? model, int? year, string? vin, string? stateNumber)
        {
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            VIN = vin;
            StateNumber = stateNumber;
        }
        public Car()
        {
            Id = null;
            Name = null;
            Model = null;
            Year = null;
            VIN = null;
            StateNumber = null;
        } 
    }

    public class CarMenu
    {
        IEnumerable<Car> cars;
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car(1, "Mercedes", "E63s", 2021, "WDDZF8KBXJA480116", "AX7777XM" ),
            new Car(2, "BMW", "M5", 2011, "WBSFV91030DW94375", "AA0041AA"),
            new Car(3, "Audi", "RS6", 2021, "WUAZZZF26MN905977", "AA4444TA")
        };

        public static void AddCar()
        {
            Car car = new Car();
            Console.Write("Id -> ");
            car.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name -> "); 
            car.Name = Console.ReadLine();
            Console.Write("Model -> "); 
            car.Model = Console.ReadLine();
            Console.Write("Year -> "); 
            car.Year = Convert.ToInt32(Console.ReadLine());
            car.VIN = VerificationInfo.ConditionForVIN();
            car.StateNumber = VerificationInfo.ConditionForStateNumber();
            Cars.Add(car);
        }
        public static void OutCar()
        {
            Console.WriteLine("Cars: ");
            foreach (var item in Cars)
            {
                Console.WriteLine($"\tId -> {item.Id}\n" +
                    $" Name -> {item.Name}\n" +
                    $" Model -> {item.Model}\n" +
                    $" Year -> {item.Year}\n" +
                    $" VIN -> {item.VIN}\n" +
                    $" State number -> {item.StateNumber}\n" +
                    $" Repair status -> {item.IsRepair}");
            }
        }


    }


}
