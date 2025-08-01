public class ElevatorRequest
{
    public int CurrentFloor { get; set; }
    public int EndFloor { get; set; }

    public ElevatorRequest(int currentFloor, int endFloor)
    {
        CurrentFloor = currentFloor;
        EndFloor = endFloor;
    }
}