namespace StarBuzz;

public enum Temperature
{
    Hot,
    Iced
}

public enum Size
{
    Small,
    Medium,
    Large
}

public abstract class Beverage
{
    public Temperature Temp { get; set; } = Temperature.Hot;
    public Size DrinkSize { get; set; } = Size.Medium;

    public abstract string Description { get; }
    public abstract decimal Cost();
    public abstract int Calories();
}