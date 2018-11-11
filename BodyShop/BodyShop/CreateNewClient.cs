using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyShop
{
    public class CreateNewClient
    {
        public static Client ClientCreation()
        {
            Random rand = new Random();
            DateTime todayTmp = ZeProgram.dayOfWork; // today + инкремент every day
            return new Client((Problems)rand.Next(2), todayTmp.AddDays(rand.Next(1, 30)));
        }
    }
}
