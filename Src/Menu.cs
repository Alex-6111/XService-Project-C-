//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using XService.Src;

//namespace XService.UI
//{
//    public class Menu
//    {
//        private static DataContext dataContext;

//        IEnumerable<Manager> managers;
//        IEnumerable<Mechanic> mechanics;
//        IEnumerable<Car> cars;

//        public void AddManager()
//        {
//            Manager manager = new Manager();
//            Console.Write("Full name -> ");
//            manager.FullName = Console.ReadLine();
//            manager.Email = VerificationInfo.ConditionForEmail();
//            manager.Password = VerificationInfo.ConditionForPassword();
//            dataContext.Managers.Add(manager);
//        }

//        public static void AddMechanic()
//        {
//            Mechanic mechanic = new Mechanic();
//            Console.Write("Full name -> ");
//            mechanic.FullName = Console.ReadLine();
//            mechanic.Email = VerificationInfo.ConditionForEmail();
//            mechanic.Password = VerificationInfo.ConditionForPassword();
//            dataContext.Mechanics.Add(mechanic);
//        }

//        public void OutManager()
//        {
//            Console.WriteLine("Managers: ");
//            foreach (var item in managers)
//            {
//                Console.WriteLine($"\t Name {item.FullName} Password {item.Password} Email {item.Email}");
//            }
//        }
       
//    }
//}
