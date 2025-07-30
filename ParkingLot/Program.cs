using System;

class Program
{
    static void Main(string[] args)
    {
        ParkingLot lot = new ParkingLot(3); 

        while (true)
        {
            Console.WriteLine("\n1. Park Car\n2. Remove Car\n3. Show Cars\n4. Exit");
            Console.Write("Enter option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter license plate: ");
                    string plate = Console.ReadLine();
                    lot.ParkCar(new Car(plate));
                    break;

                case "2":
                    Console.Write("Enter license plate to remove: ");
                    string removePlate = Console.ReadLine();
                    lot.RemoveCar(removePlate);
                    break;

                case "3":
                    lot.ShowParkedCars();
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
