using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace BodyShop
{

    public enum Problems
    { 
        Wheel_replacement,
        Body_repair
    };

    class ZeProgram
    {        
        public static DateTime dayOfWork = DateTime.Today; // рабочий день по счету (всего max value = 364, 0 - 364)
        static void Main()
        {
            BodyShopRecord bodyShopRecord = new BodyShopRecord(); // ради интерфейса пришлось создать объект
            OccupiedRepairDays occupiedRepairDays = new OccupiedRepairDays(); // и этот тоже

            Random rand = new Random();
            int tmp = 0;
            for (int dayOfYear = 0; dayOfYear < 365; dayOfYear++) // 365 дней в году але
            {
                var numberClientsToday = rand.Next(0, 5); // количество клиентов сегодня
                for (int nextClient = 0; nextClient < numberClientsToday; nextClient++)
                {
                    Client client = CreateNewClient.ClientCreation();
                    if (client.problem == 0)
                    {
                        client = bodyShopRecord.AppointmentForWheelReplacement(CreateNewClient.ClientCreation);
                    }
                    else
                    {
                        client = bodyShopRecord.AppointmentForBodyRepair(CreateNewClient.ClientCreation);
                    }

                    if (client != null) //it is working?!
                    {
                        if (client.problem == 0)
                        {
                            occupiedRepairDays.FillDaysForWheelReplacement(client);
                            tmp++;
                        }
                        else
                        {
                            occupiedRepairDays.FillDaysForBodyRepair(client);
                            tmp++;
                        }
                    }
                }
                dayOfWork = dayOfWork.AddDays(1);
            }

            dayOfWork = DateTime.Today;            
            
            for (int dayOfYear = 0; dayOfYear < 365; dayOfYear++)
            {
                Console.WriteLine(dayOfWork.ToShortDateString() + ":"); //консоль
                File.AppendAllText(@"C:\Users\proko\Desktop\Json\BodyShop.txt", dayOfWork.ToShortDateString() + ":" + Environment.NewLine); //json
                for (int nextClient = 0; nextClient < 5; nextClient++)
                {
                    if (BodyShopRecord.BodyShopShedule[nextClient, dayOfYear] != null)
                    {
                        BodyShopRecord.BodyShopShedule[nextClient, dayOfYear].Show(); //консоль
                        BodyShopRecord.BodyShopShedule[nextClient, dayOfYear].placeNumber += 1; // Json
                        var temp = JsonConvert.SerializeObject(BodyShopRecord.BodyShopShedule[nextClient, dayOfYear]); // Json 
                        File.AppendAllText(@"C:\Users\proko\Desktop\Json\BodyShop.txt", temp + Environment.NewLine); // Json 
                    }
                }
                File.AppendAllText(@"C:\Users\proko\Desktop\Json\BodyShop.txt", new string('_', 30) + Environment.NewLine); // Json 
                dayOfWork = dayOfWork.AddDays(1);
                Console.WriteLine("_______"); //консоль
            }
            Console.WriteLine("gg..."); //консоль

            Process.Start(@"C:\Users\proko\Desktop\Json\BodyShop.txt");

            //Process.Start("E:\\Programs\\parahsa\\LeagueClient.exe"); ха ару
            //Process.Start("https://yandex.ru/search/?text=гей%20порно&clid=2270455&banerid=0500000134%3A5b324ca33f07be002b40af53&win=339&lr=216");

        }
    }
}
