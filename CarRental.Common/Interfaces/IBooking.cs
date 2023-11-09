using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Interfaces;

public interface IBooking
{
    public int Id { get; }
    public int KilometersRented { get; }
    public IVehicle GetVehicleInfo();
    public IPerson GetCustomerInfo();
    public DateTime GetDayRented();
    public int GetDayReturned();
    public bool GetIsActive();
    public bool CloseBooking();
    public double GetCost();
    public void SetKilometersUsed(int kilometers);
    public int GetKilometersUsed();
    public int GetKilometersLeft();
    public void ReturnVehicle();
}
