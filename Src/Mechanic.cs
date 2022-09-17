using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace XService.Src
{
    public class Mechanic : IAccount
    {
        public int? Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Mechanic(int? id, string? fullName, string? email, string? password)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Password = password;
        }
        public Mechanic()
        {
            Id = null;
            FullName = null;
            Email = null;
            Password = null;
        }
    }

    public class MechanicMenu : Mechanic
    {
        IEnumerable<Mechanic> mechanics;

        public static List<Mechanic> Mechanics { get; set; } = new List<Mechanic>()
        {
            new Mechanic(1, "Oleg Segiyovich Boyko", "boyko@gmail.com", "boyko22")
        };

        public static void AddMechanic()
        {
            Mechanic mechanic = new Mechanic();

            Console.Write("Id -> ");
            mechanic.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Full name -> ");
            mechanic.FullName = Console.ReadLine();
            mechanic.Email = VerificationInfo.ConditionForEmail();
            mechanic.Password = VerificationInfo.ConditionForPassword();
            Mechanics.Add(mechanic);
        }
        public static void OutMechanic()
        {
            Console.WriteLine("Mechanics: ");
            foreach (var item in Mechanics)
            {
                Console.WriteLine($"\tId -> {item.Id} Name -> {item.FullName}");
            }
        }




    }
}
