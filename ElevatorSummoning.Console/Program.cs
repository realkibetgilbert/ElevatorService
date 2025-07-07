using ElevatorSummoning.Console.Application.Features.ElevatorSelector.Services;
using ElevatorSummoning.Console.Domain.Models;

const int MaxFloor = 10;

var elevators = new List<Elevator>
{
    new Elevator(1, "ELEV-1", 3),
    new Elevator(2, "ELEV-2", 7),
    new Elevator(3, "ELEV-3", 10),
};

int requestedFloor;


while (true)
{
    Console.Write($"Enter requested floor (1-{MaxFloor}): ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out requestedFloor) && requestedFloor >= 1 && requestedFloor <= MaxFloor)
    {
        break;
    }
    else
    {
        Console.WriteLine($"Invalid input. Please enter a number between 1 and {MaxFloor}.");
    }
}

var selector = new ElevatorSelectorService();
var selectedElevator = selector.GetMostEfficientElevator(elevators, requestedFloor);

Console.WriteLine($" Selected Elevator: {selectedElevator.SerialNumber}");
