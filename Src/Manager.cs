using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XService.Src
{
    public class Manager : IAccount
    {
        public int? Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        
        public Manager(int? id, string? fullName, string? email, string? password)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Password = password;
        }
        public Manager()
        {
            Id = null;
            FullName = null;
            Email = null;
            Password = null;
        } 
    }
    public class ManagerMenu : Manager
    {
        IEnumerable<Manager> managers;

        public static List<Manager> Managers { get; set; } = new List<Manager>()
        {
           new Manager(1, "Boris Petrovich Johnson", "johnson@apple.com", "qwerty52") 
        };

        
        public static void AddManager()
        {
            Manager manager = new Manager();

            Console.Write("Id -> ");
            manager.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Full name -> ");
            manager.FullName = Console.ReadLine();
            manager.Email = VerificationInfo.ConditionForEmail();
            manager.Password = VerificationInfo.ConditionForPassword();
            Managers.Add(manager);
        }
        public static void OutManager()
        {
            Console.WriteLine("Managers: ");
            foreach (var item in Managers)
            {
                Console.WriteLine($"\tId -> {item.Id} Name -> {item.FullName}");
            }
        }

        //public static void RemoveManager()
        //{
        //    int tmp = 0;
        //    Console.Write("Enter id -> "); tmp = Convert.ToInt32(Console.ReadLine());
        //    foreach (var item in Managers)
        //    {
        //        if (item.Id == tmp)
        //        {
        //            item.Managers.Remove(item);
        //        }
        //    }
        //}




    }
   

}
