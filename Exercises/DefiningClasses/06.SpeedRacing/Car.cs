using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpeedRacing;

public class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer { get; set; }
    public double TravelledDistance { get; set; }

    public bool Drive(double distanceInKm)
    {
        double fuelNeeded = distanceInKm * this.FuelConsumptionPerKilometer;
        if (fuelNeeded > this.FuelAmount)
        {
            return false;
        }

        this.FuelAmount -= fuelNeeded;
        this.TravelledDistance += distanceInKm;
        return true;
    }
}
