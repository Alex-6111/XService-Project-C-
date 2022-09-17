using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XService.Src
{
    public  class VerificationInfo
    {
        //public static string ConditionForEmail()
        //{
        //    string emailPattern = "^((([0-9A-Za-z]{1}[-0-9A-z\\" +
        //        ".]{0,30}[0-9A-Za-z]?)|([0-9A-Za-z]{1}[-0-9A-z\\" +
        //        ".]{0,30}[0-9A-Za-a]?))@([-A-Za-z]{1,}\\" +
        //        ".){1,}[-A-Za-z]{2,})$";
        //    Console.Write("Enter e-mail: ");
        //    string email = Console.ReadLine();
        //    Regex regex = new Regex(emailPattern);
        //    if (regex.IsMatch(email) == true)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        ConditionForEmail();
        //        return email;
        //    }
        //    return null;

        //    //do
        //    //{
        //    //    Console.WriteLine("Incorrect e - mail!");
        //    //    ConditionForEmail();
        //    //    return email;
        //    //} while (regex.IsMatch(email) != true);
        //    //Console.WriteLine("E-mail confirmed.");


        //    //while (regex.IsMatch(email) != true)
        //    //{
        //    //    ConditionForEmail();
        //    //    //return email;
        //    //}
        //    //return email;


        //    //Console.WriteLine(regex.IsMatch(email) ? "E-mail " +
        //    //"confirmed." : "Incorrect e - mail!");
        //    //return email;
        //}

        public static string ConditionForEmail()
        {
            string emailPattern = "^((([0-9A-Za-z]{1}[-0-9A-z\\" +
                ".]{0,30}[0-9A-Za-z]?)|([0-9A-Za-z]{1}[-0-9A-z\\" +
                ".]{0,30}[0-9A-Za-a]?))@([-A-Za-z]{1,}\\" +
                ".){1,}[-A-Za-z]{2,})$";
            Console.Write("Enter e-mail: ");
            string email = Console.ReadLine();
            Regex regex = new Regex(emailPattern);
            Console.WriteLine(regex.IsMatch(email) ? "E-mail " +
            "confirmed." : "Incorrect e - mail!");
            return email;
        }


        public static string ConditionForPassword()
        {
            string passwordPattern = "[0-9a-zA-Z]{6,}";
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Regex regex = new Regex(passwordPattern);
            Console.WriteLine(regex.IsMatch(password) ? "Password " +
            "confirmed." : "Incorrect password!");
            return password;
        }
        public static string ConditionForVIN()
        {
            string vinPattern = "^[A-HJ-NPR-Z0-9]{17}$";
            Console.Write("Enter VIN number: ");
            string vin = Console.ReadLine();
            Regex regex = new Regex(vinPattern);
            Console.WriteLine(regex.IsMatch(vin) ? "VIN number " +
            "confirmed." : "Incorrect VIN number!");
            return vin;
        }
        public static string ConditionForStateNumber()
        {
            string stateNumberPattern = "^[ABCEHIKMOPTX]{2}\\d{4}(?<!0{4})[ABCEHIKMOPTX]{2}$";
            Console.Write("Enter state number: ");
            string stateNumber = Console.ReadLine();
            Regex regex = new Regex(stateNumberPattern);
            Console.WriteLine(regex.IsMatch(stateNumber) ? "State number " +
            "confirmed." : "Incorrect state number!");
            return stateNumber;
        }
    }
}
