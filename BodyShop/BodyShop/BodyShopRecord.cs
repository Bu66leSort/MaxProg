using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyShop
{
    public class BodyShopRecord : IBodyShopRecord
    {
        public static int dayOfYear = 0;
        public static Client[,] BodyShopShedule = new Client[5, 365];
        public static DateTime beginningOfWork = DateTime.Today; // дата начала, чтоб выбирать ячейки в массиве, кек
        public delegate Client NewClient();

        public Client AppointmentForWheelReplacement(NewClient newClient) // мб сюда поставить ref
        {
            Client client = new Client(newClient()); // как обратиться к ебаному делегату без переменной (в контрольных значениях отладки он рандомит)
            int dayForAppointment = (client.visitDate - beginningOfWork).Days;
            for (int placeNumber = 0; placeNumber < 5; placeNumber++)
            {
                if (dayForAppointment < 362 && BodyShopShedule[placeNumber, dayForAppointment] == null) // && placeFound == false
                {
                    int freePlaceFound = 1;

                    for (int needPlace = 1; needPlace < 3; needPlace++) 
                    { 
                        if (BodyShopShedule[placeNumber, dayForAppointment + needPlace] == null)
                        {
                            freePlaceFound++;
                            if (freePlaceFound == 3)
                            {
                                client.placeNumber = placeNumber;
                                BodyShopShedule[placeNumber, dayForAppointment] = client;
                                return client;
                            }
                        }
                        else
                        {
                            break; // самый бесполезный break в жизни... но да похуй
                        }
                    }
                }
            }
            return null; // вместо return null, который работать не хочет
        }

        public Client AppointmentForBodyRepair(NewClient newClient)
        {
            Client client = new Client(newClient()); // как обратиться к ебаному делегату без переменной (в контрольных значениях отладки он рандомит)
            int dayForAppointment = (client.visitDate - beginningOfWork).Days;
            for (int placeNumber = 0; placeNumber < 5; placeNumber++)
            {
                if (dayForAppointment < 355 && BodyShopShedule[placeNumber, dayForAppointment] == null) // && placeFound == false
                {
                    int freePlaceFound = 1;

                    for (int needPlace = 1; needPlace < 10; needPlace++)
                    {
                        if (BodyShopShedule[placeNumber, dayForAppointment + needPlace] == null)
                        {
                            freePlaceFound++;
                            if (freePlaceFound == 10)
                            {
                                client.placeNumber = placeNumber;
                                BodyShopShedule[placeNumber, dayForAppointment] = client;
                                return client;
                            }
                        }
                        else
                        {
                            break; // а тут он не такой уж и бесполезный, хы
                        }
                    }
                }
            }
            return null; 
        }
    }
}
