using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE

// Classes inherit properties of another class.  PARENT, GRAND CHILD RELATIONSHIP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //SAMPLES 
            Car BigCar = new Car();

            Corolla whiteCorolla = new Corolla();

            Smartphone smartphone = new Smartphone();

            smartphone.Apps.Add("WhatsApp Messenger");

            LandLine landLine = new LandLine();

            landLine.PlaceCall();

            Phone phone = new Smartphone();

            List<Phone> phones = new List<Phone>(); 
            

            //Another way of usind inheritance
            phones.Add(new Smartphone());
            phones.Add(new LandLine());
            Console.ReadLine();

            foreach (var phone1 in phones)
            {
                if (phone1 is CellPhone cell) // If Phone1 belongs to Cell phone then let Phone1 use properties from Cellphone with the variable "cell"
                {
                    cell.EndCall();
                    cell.Carrier= "Telia";
                }

                if (phone1 is Smartphone Smartphone)
                {
                    Smartphone.ConnectInterner();
                }
            }
        }
    }
}
