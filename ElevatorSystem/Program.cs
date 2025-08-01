
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        // Flow will 1.user will assign total number of lifts
        // 2.then he will assign request to the lifts based on the assigned number of lifts
        // 3. That lift will be that request will be added to queue 
        // 4. then in update method that status will changed using enum 
        // 5. then one counter will be started based on the addition of floor assigned by the user 
        // 6. And then it will increment or decrement the floor in the current floor
        //  variable once it reached to the mentioned floor then it will set the status of the lift as idle 

        var system = new ElevatorSystem(2);

        system.RequestElevator(0, 5);
        system.RequestElevator(3, 7);
        
        for (int i = 0; i < 10; i++)
        {
            system.step();
            System.Threading.Thread.Sleep(1000); // Simulate time passing
        }
    }
}