using CarRental.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Interfaces;

public interface IVehicle
{
    public string Make { get; }
    public VehicleTypes VehicleType { get; }
    public int CostPerDay { get; }
    public int CostPerKilometer { get; }
    public string Registration { get; }
    public void SetVehicleStatus(VehicleStatuses status);
    public VehicleStatuses GetVehicleStatus();

    public void SetOdometer(int value);
    public int GetOdometer();

}
