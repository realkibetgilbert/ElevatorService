using ElevatorSummoning.Console.Application.Features.ElevatorSelector.Interfaces;
using ElevatorSummoning.Console.Domain.Models;

namespace ElevatorSummoning.Console.Application.Features.ElevatorSelector.Services
{
    public class ElevatorSelectorService : IElevatorSelectorService
    {
        public Elevator GetMostEfficientElevator(IEnumerable<Elevator> elevators, int requestedFloor)
        {
            return elevators
                .OrderBy(e => Math.Abs(e.CurrentFloor - requestedFloor))
                .First();
        }
    }
}
