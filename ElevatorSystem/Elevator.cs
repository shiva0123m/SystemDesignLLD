public class Elevator
{
    int CurrentFloor;
    public ElevatorStatus Status { get; set; }
    int id;
    private Queue<ElevatorRequest> requestQueue;

    public Elevator(int id)
    {
        this.id = id;
        this.CurrentFloor = 0; // Assuming ground floor is 0
        this.Status = ElevatorStatus.Idle;
        this.requestQueue = new Queue<ElevatorRequest>();
    }

    public void AddRequest(ElevatorRequest request)
    {
        requestQueue.Enqueue(request);
        UpdateRequestStatus(request);
    }
    public void UpdateRequestStatus(ElevatorRequest request)
    {
        if (request.CurrentFloor < request.EndFloor)
        {
            Status = ElevatorStatus.MovingUp;
        }
        else if (request.CurrentFloor > request.EndFloor)
        {
            Status = ElevatorStatus.MovingDown;
        }
        else
        {
            Status = ElevatorStatus.Idle;
        }
    }
    public void Step()
    {
        if (requestQueue.Count == 0)
        {
            Status = ElevatorStatus.Idle;
            return;
        }

        var request = requestQueue.Peek();
        if (CurrentFloor < request.CurrentFloor)
        {
            CurrentFloor++;
            Status = ElevatorStatus.MovingUp;
        }
        else if (CurrentFloor > request.CurrentFloor)
        {
            CurrentFloor--;
            Status = ElevatorStatus.MovingDown;
        }
        else
        {
            // Reached the requested floor
            Console.WriteLine($"Elevator {id} has reached floor {CurrentFloor} for request from {request.CurrentFloor} to {request.EndFloor}.");
            requestQueue.Dequeue(); // Remove the completed request
            UpdateRequestStatus(request);
        }
    }
}