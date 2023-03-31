using cab_service.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cab_service.Scenarios
{
    public class Scen1
    {
        CallCenter callCenter;

        Cab cab1;
        Cab cab2;

        Passenger passenger1;

        public Scen1()
        {
            callCenter = new CallCenter();

            cab1 = new Cab("Cab1", 16, true);
            cab2 = new Cab("Cab2", 17, true);

            passenger1 = new Passenger("passenger1", "11 street", 12);

            callCenter.Register(cab1);
            callCenter.Register(cab2);

            callCenter.BookCab(passenger1);
        }

        
    }
}
