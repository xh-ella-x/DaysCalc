using FluentAssertions;
using Xunit;

namespace DaysCalc.UnitTests;

public class RemainingAmountOfDaysTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(-1, 0)]
    public void CurrentDate_GreaterThan_ValidTo(int input, int expected)
    {
        //Act
        var AmountOfDays = 6;
        var now = DateTime.Now.Date;
        var ValidFrom = DateTime.Now.AddDays(-9);
        var Diff = now.Subtract(ValidFrom);

        //Assert
        var RemainingAmountOfDays = (AmountOfDays - (int)(DateTime.Now.Date - ValidFrom.Date).TotalDays) >= 0 ? (AmountOfDays - (int)(DateTime.Now.Date - ValidFrom.Date).TotalDays) : 0;
        RemainingAmountOfDays.Should().Be(0);
    }
}