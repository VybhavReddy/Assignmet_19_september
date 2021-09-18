using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class viewMaintenance
    {
        float weight,price;
        public void checkLuggage(int classs)
        {
            
            Console.WriteLine("The flight is Ready to onboard after luggage verification");
            Console.WriteLine("Enter the Weight of ur luggage in Kg");
            weight=float.Parse(Console.ReadLine());
            if(classs==1)
            {
                if(weight<50)
                {
                    price = 70;
                    Console.WriteLine("No extra charges for luggage, flight booking chrges are: 70$");
                }
                else
                {
                    float extra = (weight - 50) * 2;
                    Console.WriteLine("You exceed the allowable luggage limit the extra charges are: {0}$ total: {1}", extra, extra+70);
                    price = extra + 70;
                }
            }
            if (classs == 2)
            {
                if (weight < 40)
                {
                    price = 50;
                    Console.WriteLine("No extra charges for luggage, flight booking chrges are: 50$");
                }
                else
                {
                    float extra = (weight - 40) * 2;
                    Console.WriteLine("You exceed the allowable luggage limit the extra charges are: {0}$ total: {1}", extra, extra + 50);
                    price = extra + 50;
                }
            }
            if (classs == 3)
            {
                if (weight < 20)
                {
                    price =30;
                    Console.WriteLine("No extra charges for luggage, flight booking chrges are: 30$");
                }
                else
                {
                    float extra = (weight - 20) * 2;
                    Console.WriteLine("You exceed the allowable luggage limit the extra charges are: {0}$ total: {1}", extra, extra + 30);
                    price = extra + 30;
                }
            }
        }
        public float print()
        {
            return price;
        }
    }
    
}
