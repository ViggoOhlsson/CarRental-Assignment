using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Classes
{
    public class Collections
    {
        readonly List<IPerson> _personsCollection = new();
        readonly List<IVehicle> _vehiclesCollection = new();
        readonly List<IBooking> _bookingsCollection = new();

        public Collections() => InitDatabase();

        void InitDatabase()
        {

            _personsCollection.AddRange(new List<IPerson>{
                new Customer("Viggo", "Ohlsson", 192734),
                new Customer("Staffan", "Struts", 016247),
                new Customer("Björne", "Långkalsong", 037591),
                new Customer("Pling", "Plong", 439264)
            });

            _vehiclesCollection.AddRange(new List<IVehicle>
            {
                new Car("Volvo", VehicleTypes.Combi, 3, 200, 10000, "SKC924"),
                new Car("Volkswagen", VehicleTypes.Combi, 2, 300, 15000, "KWL283"),
                new Car("Subaru", VehicleTypes.Combi, 3, 300, 19000, "PLK76B"),
                new Car("Jeep", VehicleTypes.Van, 3, 400, 12000, "HEJ123"),
                new Motorcycle("Honda", VehicleTypes.Motorcycle, 1, 150, 20000, "CBL088")
            });

            _bookingsCollection.AddRange(new List<IBooking>
            {
                new Booking(0, _vehiclesCollection[1], _personsCollection[0], 1000, DateTime.Now),
                new Booking(1, _vehiclesCollection[4], _personsCollection[3], 1500, DateTime.Now),
                new Booking(2, _vehiclesCollection[2], _personsCollection[2], 1500, DateTime.Now),
            });

            _bookingsCollection[1].ReturnVehicle();

            _vehiclesCollection[1].SetVehicleStatus(VehicleStatuses.Unavailable);
            _vehiclesCollection[2].SetVehicleStatus(VehicleStatuses.Unavailable);
        }

        public IEnumerable<IPerson> GetPersons() => _personsCollection;
        public IEnumerable<IVehicle> GetVehicles() => _vehiclesCollection;
        public IEnumerable<IBooking> GetBookings() => _bookingsCollection;

        public void SetVehicleStatus(IVehicle vehicle, VehicleStatuses status)
        {
            try
            {
                for (int i = 0; i > _vehiclesCollection.Count; i++)
                {
                    if (vehicle.Registration == _vehiclesCollection[i].Registration)
                    {
                        _vehiclesCollection[i].SetVehicleStatus(status);
                    }
                }

            } catch
            {
                Console.WriteLine("error :))");
            }
        }
    }
}
