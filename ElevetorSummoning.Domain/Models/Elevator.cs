namespace ElevatorSummoning.Console.Domain.Models
{
    public class Elevator
    {
        public int Id { get; }
        public string SerialNumber { get; }
        public long CurrentFloor { get; set; }

        public Elevator(int id, string serialNumber, int currentFloor)
        {
            Id = id;
            SerialNumber = serialNumber;
            CurrentFloor = currentFloor;
        }
        public void MoveTo(int floor)
        {
            CurrentFloor = floor;
        }


    }
}
