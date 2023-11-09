using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Classes;

public class BookingManager {

    private readonly Collections Collections = new();

    public BookingManager()
    {

    }
    public IEnumerable<IBooking> GetAllBookings() => Collections.GetBookings();
    public IEnumerable<IVehicle> GetAllVehicles() => Collections.GetVehicles();
    public IEnumerable<IPerson> GetAllPersons() => Collections.GetPersons();

    public void SetStatusOfVehicle(IVehicle vehicle, bool status)
    {
        if (status) Console.WriteLine($"Set status to true");
        else Console.WriteLine($"Set status to false");
        Collections.SetVehicleStatus(vehicle, status ? VehicleStatuses.Available : VehicleStatuses.Unavailable);
    }
}
