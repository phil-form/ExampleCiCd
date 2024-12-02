namespace ConsoleApp1;

public class Car
{
    public int Speed { get; set; }

    public int IncreaseSpeed(int amount)
    {
        if (amount < 0)
        {
            throw new Exception();
        }
        this.Speed += amount / 2;

        return this.Speed;
    }
}