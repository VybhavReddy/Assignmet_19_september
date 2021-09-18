using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class bookTickets
    {
        string name;
        int bookingClass;
        int age;
        string passport_characters;
        public int ticketBooking()
        {
            Console.WriteLine("Enter your name ");
            name=Console.ReadLine();
            Console.WriteLine("Enter your Passport ID characters");
            passport_characters= Console.ReadLine();
            Console.WriteLine("Enetr your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for first class \n2 for Business class\n3 for Economy class");
            bookingClass = Convert.ToInt32(Console.ReadLine());
            return bookingClass;
        }
        public string namee()
        {
            return name;
        }
    }
}
