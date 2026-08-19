namespace StarBuzz;

public sealed class HouseBlend : Beverage
{
    public HouseBlend(Size size = Size.Medium, Temperature temp = Temperature.Hot)
    {
        DrinkSize = size;
        Temp = temp;
    }

    public override string Description => $"{DrinkSize} {Temp} House Blend";

    public override decimal Cost() => DrinkSize switch
    {
        Size.Small => 1.75m,
        Size.Medium => 2.00m,
        Size.Large => 2.50m,
        _ => 2.00m
    };

    public override int Calories() => DrinkSize switch
    {
        Size.Small => 5,
        Size.Medium => 10,
        Size.Large => 15,
        _ => 10
    };
}

public sealed class DarkRoast : Beverage
{
    public DarkRoast(Size size = Size.Medium, Temperature temp = Temperature.Hot)
    {
        DrinkSize = size;
        Temp = temp;
    }

    public override string Description => $"{DrinkSize} {Temp} Dark Roast";

    public override decimal Cost() => DrinkSize switch
    {
        Size.Small => 2.50m,
        Size.Medium => 3.00m,
        Size.Large => 3.50m,
        _ => 3.00m
    };

    public override int Calories() => DrinkSize switch
    {
        Size.Small => 5,
        Size.Medium => 10,
        Size.Large => 15,
        _ => 10
    };
}

public sealed class Decaf : Beverage
{
    public Decaf(Size size = Size.Medium, Temperature temp = Temperature.Hot)
    {
        DrinkSize = size;
        Temp = temp;
    }

    public override string Description => $"{DrinkSize} {Temp} Decaf";

    public override decimal Cost() => DrinkSize switch
    {
        Size.Small => 2.50m,
        Size.Medium => 3.00m,
        Size.Large => 3.50m,
        _ => 3.00m
    };

    public override int Calories() => DrinkSize switch
    {
        Size.Small => 5,
        Size.Medium => 10,
        Size.Large => 15,
        _ => 10
    };
}

public sealed class Espresso : Beverage
{
    public Espresso(Size size = Size.Medium, Temperature temp = Temperature.Hot)
    {
        DrinkSize = size;
        Temp = temp;
    }

    public override string Description => $"{DrinkSize} {Temp} Espresso";

    public override decimal Cost() => DrinkSize switch
    {
        Size.Small => 1.75m,
        Size.Medium => 2.00m,
        Size.Large => 2.40m,
        _ => 2.00m
    };

    public override int Calories() => DrinkSize switch
    {
        Size.Small => 5,
        Size.Medium => 10,
        Size.Large => 15,
        _ => 10
    };
}