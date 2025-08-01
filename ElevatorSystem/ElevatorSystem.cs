using System.Diagnostics.Contracts;

public class ElevatorSystem
{
    List<Elevator> elevators = new List<Elevator>();

    public ElevatorSystem(int numberOfElevators)
    {
        Contract.Requires(numberOfElevators > 0, "Number of elevators must be greater than zero.");

        for (int i = 0; i < numberOfElevators; i++)
        {
            elevators.Add(new Elevator(i));
        }
    }

    public void RequestElevator(int fromFloor, int toFloor)
    {
        Contract.Requires(fromFloor >= 0, "From floor must be non-negative.");
        Contract.Requires(toFloor >= 0, "To floor must be non-negative.");
        Contract.Requires(fromFloor != toFloor, "From and to floors must be different.");

        foreach (var ele in elevators)
        {
            if (ele.Status == ElevatorStatus.Idle)
            {
                ele.AddRequest(new ElevatorRequest(fromFloor, toFloor));
                return;
            }
            
        }

    }

    public void step()
    {
        foreach (var ele in elevators)
        {
            ele.Step();
        }
    }
}