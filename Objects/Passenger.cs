using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cab_service.Objects;

internal interface IPassenger
{
    string Name { get; }
    string DropLocation { get; }
    int Location { get; }

    void Notification(ICab cab);

}

internal class Passenger : IPassenger
{
    string _name;
    string _dropLocation;
    int _location;
    public string Name => _name;

    public string DropLocation => _dropLocation;

    public int Location => _location;

    public void Notification(ICab cab)
    {
        Console.WriteLine($"your Cab is : {cab.Name}, its Currently at {cab.CurrentLocation}");
    }
}