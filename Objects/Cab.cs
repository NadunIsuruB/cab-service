using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cab_service.Objects;

internal interface ICab
{
    string Name { get; }

    int CurrentLocation { get; }

    bool IsActive { get; }

    void Assign(string passenger, string dropLocation);
}

internal class Cab : ICab
{
    string _name;
    int _currentLocation;
    bool _isActive;

    public Cab(string name, int currentLocation, bool isActive)
    {
        _name = name;
        _currentLocation = currentLocation;
        _isActive = isActive;
    }

    public string Name => _name;

    public int CurrentLocation => _currentLocation;

    public bool IsActive => _isActive;

    public void Assign(string passenger, string dropLocation)
    {
        Console.WriteLine($"{Name} Assign to {passenger} to go {dropLocation}");
    }
}