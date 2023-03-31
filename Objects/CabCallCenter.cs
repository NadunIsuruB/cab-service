using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cab_service.Objects;

internal interface ICabCallCenter
{
    void Register(ICab cab);
    void Unregister(ICab cab);
    void BookCab(IPassenger passenger);

}

internal class CabCallCenter : ICabCallCenter
{
    private readonly Dictionary<string, ICab> cabs = new Dictionary<string, ICab>;

    public void BookCab(IPassenger passenger)
    {
        foreach (var cab in cabs.Values.Where(c => c.IsActive))
        {
            if(InTheRadius(cab.CurrentLocation, passenger.Location))
            {
                cab.Assign(passenger.Name, passenger.DropLocation);
                passenger.Notification(cab);
            }

        }
    }

    public void Register(ICab cab)
    {
        if(!cabs.ContainsValue(cab)) cabs.Add(cab.Name, cab);
    }

    public void Unregister(ICab cab)
    {
        if (!cabs.ContainsValue(cab)) cabs.Remove(cab.Name);
    }

    private bool InTheRadius(int cabLocation, int passengerLocation, int raius = 5) => 
        Math.Abs(cabLocation - passengerLocation) < raius; 
}
