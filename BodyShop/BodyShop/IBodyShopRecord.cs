using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyShop
{
    interface IBodyShopRecord
    {
        Client AppointmentForWheelReplacement(BodyShopRecord.NewClient newClient);

        Client AppointmentForBodyRepair(BodyShopRecord.NewClient newClient);
    }
}
