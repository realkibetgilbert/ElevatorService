using ElevatorSummoning.Console.Application.Features.ElevatorSelector.Services;
using ElevatorSummoning.Console.Domain.Models;

namespace ElevatorSummoning.Console.Tests.Services.ElevatorService
{
    public class ElevatorSelectorServiceTests
    {
        [Fact]
        public void Returns_Elevator_Closest_To_Requested_Floor()
        {
            var elevators = new List<Elevator>
            {
                new Elevator(1, "E1", 2),
                new Elevator(2, "E2", 6),
                new Elevator(3, "E3", 10)
            };

            var selector = new ElevatorSelectorService();
            var result = selector.GetMostEfficientElevator(elevators, 7);

            Assert.Equal("E2", result.SerialNumber);
        }

        [Fact]
        public void Returns_First_Of_Equally_Close_Elevators()
        {
            var elevators = new List<Elevator>
            {
                new Elevator(1, "E1", 4),
                new Elevator(2, "E2", 6),
                new Elevator(3, "E3", 10)
            };

            var selector = new ElevatorSelectorService();
            var result = selector.GetMostEfficientElevator(elevators, 5);

            Assert.Equal("E1", result.SerialNumber);
        }

        [Fact]
        public void Returns_Elevator_On_Requested_Floor()
        {
            var elevators = new List<Elevator>
            {
                new Elevator(1, "E1", 3),
                new Elevator(2, "E2", 5),
                new Elevator(3, "E3", 8)
            };

            var selector = new ElevatorSelectorService();
            var result = selector.GetMostEfficientElevator(elevators, 5);

            Assert.Equal("E2", result.SerialNumber);
        }

        [Fact]
        public void Returns_First_Elevator_When_All_Are_On_Same_Floor()
        {
            var elevators = new List<Elevator>
            {
                new Elevator(1, "E1", 4),
                new Elevator(2, "E2", 4),
                new Elevator(3, "E3", 4)
            };

            var selector = new ElevatorSelectorService();
            var result = selector.GetMostEfficientElevator(elevators, 2);

            Assert.Equal("E1", result.SerialNumber);
        }
    }
}
