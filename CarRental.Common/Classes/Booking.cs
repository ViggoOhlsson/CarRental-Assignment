using CarRental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public int Id { get; init; }
    private IVehicle Vehicle { get; set; }
    private IPerson Customer { get; set; }
    private bool IsActive { get; set; } = true;
    private DateTime DayRented { get; init; }
    private int DayReturned { get; set; } = new Random().Next(1, 4);

    public int KilometersRented { get; init; }
    private int KilometersUsed { get; set; } = new Random().Next(1000);

    private int Cost { get; set; } = 0;
    public Booking(int id, IVehicle vehicle, IPerson customer, int kilometersRented, DateTime dayRented)
    {
        (Id, Vehicle, Customer, KilometersRented, DayRented) = (id, vehicle, customer, kilometersRented, dayRented);
    }

    public bool GetIsActive() => IsActive;

    public bool CloseBooking() => IsActive = false;

    public void SetKilometersUsed(int kilometers) => KilometersUsed = kilometers;
    public int GetKilometersLeft() => KilometersRented - KilometersUsed;
    public int GetKilometersUsed() => KilometersUsed;
    public double GetCost() => Cost;
    public IPerson GetCustomerInfo() => Customer;
    public IVehicle GetVehicleInfo() => Vehicle;
    public DateTime GetDayRented() => DayRented;
    public int GetDayReturned() => DayReturned;    
    public void ReturnVehicle()
    {
        double DayCost = Vehicle.CostPerDay * DayReturned;
        double DistanceCost = Vehicle.CostPerKilometer * KilometersUsed;
        Cost = Convert.ToInt32(DayCost + DistanceCost);
        IsActive = false;

    }
}
