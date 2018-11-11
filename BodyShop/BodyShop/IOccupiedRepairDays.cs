using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyShop
{
    interface IOccupiedRepairDays
    {
        void FillDaysForWheelReplacement(Client client);

        void FillDaysForBodyRepair(Client client);
    }
}
