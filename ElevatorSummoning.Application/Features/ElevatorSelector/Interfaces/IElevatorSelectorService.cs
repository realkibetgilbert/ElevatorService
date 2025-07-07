using ElevatorSummoning.Console.Domain.Models;

namespace ElevatorSummoning.Console.Application.Features.ElevatorSelector.Interfaces
{
    public interface IElevatorSelectorService
    {
        Elevator GetMostEfficientElevator(IEnumerable<Elevator> elevators, int requestedFloor);
    }
}
