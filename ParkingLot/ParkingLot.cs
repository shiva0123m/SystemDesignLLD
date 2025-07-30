using System;
using System.Collections.Generic;

public class ParkingLot
{
    private int capacity;
    private List<Car> parkedCars;

    public ParkingLot(int capacity)
    {
        this.capacity = capacity;
        parkedCars = new List<Car>();
    }

    public bool ParkCar(Car car)
    {
        if (parkedCars.Count >= capacity)
        {
            Console.WriteLine("Parking Lot is full.");
            return false;
        }

        parkedCars.Add(car);
        Console.WriteLine($"Car with license {car.LicensePlate} parked.");
        return true;
    }

    public bool RemoveCar(string licensePlate)
    {
        Car carToRemove = parkedCars.Find(car => car.LicensePlate == licensePlate);
        if (carToRemove != null)
        {
            parkedCars.Remove(carToRemove);
            Console.WriteLine($"Car with license {licensePlate} removed.");
            return true;
        }

        Console.WriteLine($"Car with license {licensePlate} not found.");
        return false;
    }

    public void ShowParkedCars()
    {
        Console.WriteLine("Parked Cars:");
        foreach (Car car in parkedCars)
        {
            Console.WriteLine(car.LicensePlate);
        }

        if (parkedCars.Count == 0)
        {
            Console.WriteLine("No cars parked.");
        }
    }
}
