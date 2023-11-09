using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Classes;

public class Car : IVehicle
{
    public string Make { get; init; }
    public VehicleTypes VehicleType { get; init; }
    public int CostPerKilometer { get; init; }
    public int CostPerDay { get; init; }
    private int OdometerCount { get; set; }
    private VehicleStatuses VehicleStatus { get; set; }
    public string Registration { get; init; }



    public Car(string make, VehicleTypes type, int costPerKilometer, int costPerDay, int odometerCount, string registration)
    {
        Make = make;
        VehicleType = type;
        CostPerKilometer = costPerKilometer;
        CostPerDay = costPerDay;
        OdometerCount = odometerCount;
        VehicleStatus = default;
        Registration = registration;
    }
    public int GetOdometer() => OdometerCount;
    public void SetOdometer(int value) => OdometerCount = value;
    public VehicleStatuses GetVehicleStatus() => VehicleStatus;
    public void SetVehicleStatus(VehicleStatuses status) => VehicleStatus = status;


}
