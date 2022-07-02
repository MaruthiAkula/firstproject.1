using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? Tickets_on_Sale = null;
            int available_tickets;
            if (Tickets_on_Sale == null)
            {
                available_tickets = 0;
            }
            else
            {
                available_tickets = (int)Tickets_on_Sale;
            }
            Console.WriteLine("available Ticket is {0}", available_tickets);
        }
    }
}
