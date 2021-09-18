using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of passengers");
            int checkClass=0;
            
            int num = Convert.ToInt32(Console.ReadLine());
            bookETicket[] obj = new bookETicket[num];
            viewMaintenance[] view = new viewMaintenance[num];
            for (int i = 0; i < num; i++)
            {
                obj[i] = new bookETicket();
                checkClass=obj[i].ticketBooking();
                obj[i].e_ticket();
                view[i] = new viewMaintenance();
                view[i].checkLuggage(checkClass);
                Console.WriteLine();
                if (i < num - 1)
                    Console.WriteLine("Continuing with next passenger registration");
            }
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("The registered passengers are :\nName    Cost");
            for(int i=0;i<num;i++)
            {
                Console.WriteLine(obj[i].namee() +"    "+view[i].print());
            }
            Console.Read();
        }
    }
}