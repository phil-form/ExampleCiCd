using ConsoleApp1;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void TestWrongSpeed()
    {
        Car car = new Car();

        car.Speed = 10;

        Assert.Equal(10, car.Speed);

        car.IncreaseSpeed(25);
        Assert.NotEqual(35, car.Speed);
    }

    [Fact]
    public void TestRightSpeed()
    {
        Car car = new Car();

        car.Speed = 10;

        Assert.Equal(10, car.Speed);

        car.IncreaseSpeed(25);
        Assert.Equal(10 + (25 / 2), car.Speed);
    }

    [Fact]
    public void TestSpeedException()
    {
        Car car = new Car();

        car.Speed = 10;

        Assert.Equal(10, car.Speed);

        Assert.Throws<Exception>(() => car.IncreaseSpeed(-25));
    }
}