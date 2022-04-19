using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates//Delegates is the type safe function pointer
                   //the signature of delegates must mache the signature of the method otherwise you will get compile time error
                   //Delegates is very similar to method and class
{
    //Delegates syntex: public void GetEmployee(string )
    delegate bool CheckGender(string gender);//we have to make delegates object 
     delegate bool IscorrectGender(Gender gen);
    public enum Gender
    {
        Male,Female,other
    }
    public delegate void Messgae(int i, char j); 
    class Order
    {
        public void M1(int a, char j)
        {
        }
        public static bool VerifiedGender(Gender msg)
        {
            List<Gender> genders = new List<Gender>();
            genders.Add(Gender.Female);
            genders.Add(Gender.Male);
            genders.Add(Gender.other);

            return true;
        }
        public static bool verifiedGender(string msg)
        {
            Console.WriteLine(msg);
            if (msg == "M")
            {
                return true;
            }
            else if (msg == "F")
            {
                return true;

            }
            else if (msg == "o")
            {
                return true;

            }
            else
            {
                return false;

            }
        }
        public static void Main(string[] args)
        {
            CheckGender checkGender = new CheckGender(verifiedGender);//delegate signature should mached method signature or method return type.
            checkGender("M");
            Console.WriteLine("the end");
            Order order = new Order();
            Messgae messgae = new Messgae(order.M1);
            Console.ReadLine();
            //imp: what is the worde of delegate?
            //delegates very similar to the method.
            //delegate is a keyword. delegate is type safe function point, delegate signature must mach the function and signature dlegate is similar to method and similar to class
            //shear the screen make the program
            //delegate is used to support framwork support
            //Delegate call the function that return type is same .
        }
    }
   
}
