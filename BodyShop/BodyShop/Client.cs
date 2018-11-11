using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyShop
{
    public class Client : IClient
    {
        public Problems problem { get; private set; }
        public DateTime visitDate { get; private set; }
        public int daysInside { get; set; }
        public int placeNumber { get; set; }

        public Client(Problems problem, DateTime visitDate)
        {
            this.problem = problem;
            this.visitDate = visitDate;
            daysInside = 1;
        }

        public Client(Client obj)
        {
            daysInside = obj.daysInside;
            problem = obj.problem;
            placeNumber = obj.placeNumber;
            visitDate = obj.visitDate;
        } // конструктор копирования нид

        public Client() { }

        public void Show()
        {
            if (problem == 0)
            {
                Console.WriteLine(problem.ToString() + " | " + visitDate.ToShortDateString() + 
                    " | " + (placeNumber + 1) + " | " + daysInside + "/3 days inside");
            }
            else
            {
                Console.WriteLine(problem.ToString() + "       | " + visitDate.ToShortDateString() +
                    " | " + (placeNumber + 1) + " | " + daysInside + "/10 days inside");
            }
        }
    }
}
