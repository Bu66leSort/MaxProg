using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyShop
{
    interface IClient
    {
        //Problems problem { get; private set; } нельзя использовать модификаторы доступа в интерфейсах в свойствах
        //DateTime visitDate { get; private set; } дада нельзя
        int daysInside { get; set; }
        int placeNumber { get; set; }

        void Show();
    }
}
