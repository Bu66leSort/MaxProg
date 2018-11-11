using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyShop
{
    class BodyShopRecordr
    {
        public static int dayOfYear = 0;
        public static Client[,] BodyShopShedule = new Client[5, 365];
        public static DateTime beginningOfWork = DateTime.Today; // дата начала, чтоб выбирать ячейки в массиве, кек
        public delegate Client NewClient();

        public static Client AppointmentForWheelReplacement(NewClient newClient) // мб сюда поставить ref
        {
            //Client client = newClient(); // как обратиться к ебаному делегату без переменной (в контрольных значениях отладки он рандомит)
            int dayForAppointment = (newClient().visitDate - beginningOfWork).Days - 1;
            for (int placeNumber = 0; placeNumber < 5; placeNumber++)
            {
                //bool placeFound = false;
                if (BodyShopShedule[placeNumber, dayForAppointment] == null) // && placeFound == false
                {
                    int freePlaceFound = 1;

                    for (int needPlace = 1; needPlace < 3; needPlace++)
                    {
                        if (BodyShopShedule[placeNumber, dayForAppointment + needPlace] == null)
                        {
                            freePlaceFound++;
                            if (freePlaceFound == 3)
                            {
                                //placeFound = true;
                                newClient().placeNumber = placeNumber;
                                BodyShopShedule[placeNumber, dayForAppointment] = newClient();
                                return newClient();
                            }
                        }
                        else
                        {
                            break; // самый бесполезный break в жизни... но да похуй
                        }
                    }
                }
            }
            return null; // вместо return null, который работать не хочет ска
        }
    }
}
