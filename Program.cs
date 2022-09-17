using XService.Src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Diagnostics;

namespace XService
{
  public  class Program
    {
        static void Main()
        {

            Console.Title = "XService";
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n-----------------Wellcome to XService-------------------\n\n");

            //var testManager = new Manager();
            //testManager.EnterInfo();
            //Console.WriteLine(testManager);

            //var testM = new Mechanic();
            //testM.AddMechanic();

            //Console.WriteLine(testM);

            //MechanicMenu.AddMechanic();
            //MechanicMenu.OutMechanic();

            //ManagerMenu.AddManager();
            //ManagerMenu.OutManager();
            //ManagerMenu.AddManager();

            //ManagerMenu.OutManager();
            //ManagerMenu.AddManager();
            //ManagerMenu.OutManager();

            //CarMenu.AddCar();
            CarMenu.OutCar();


            Console.ReadKey();
        }
    }
}