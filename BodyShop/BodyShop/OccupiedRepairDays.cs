using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyShop
{
    public class OccupiedRepairDays : IOccupiedRepairDays
    {
        public void FillDaysForWheelReplacement(Client client)
        {
            int dayForAppointment = (client.visitDate - BodyShopRecord.beginningOfWork).Days; // МОЖЕТ -1 ИЛИ НЕТ ХУЙ ПОЙМИ ПИЗДОС
            for (int dayInside = 1; dayInside < 3; dayInside++)
            {
                Client tmp = new Client(client); // через new client
                tmp.daysInside += dayInside;
                BodyShopRecord.BodyShopShedule[client.placeNumber, dayForAppointment + dayInside] = new Client(tmp);
                // думаю тут он записывает в след ячейку, а не в ту, которую должен
            }
        }

        public void FillDaysForBodyRepair(Client client)
        {
            int dayForAppointment = (client.visitDate - BodyShopRecord.beginningOfWork).Days; // МОЖЕТ -1 ИЛИ НЕТ ХУЙ ПОЙМИ ПИЗДОС
            for (int dayInside = 1; dayInside < 10; dayInside++)
            {
                Client tmp = new Client(client); // через new client
                tmp.daysInside += dayInside;
                BodyShopRecord.BodyShopShedule[client.placeNumber, dayForAppointment + dayInside] = new Client(tmp);
                // думаю тут он записывает в след ячейку, а не в ту, которую должен
            }
        }
    }
}
