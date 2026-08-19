namespace StarBuzz;

public sealed class SteamedMilk : AddOnDecorator
{
    public SteamedMilk(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Steamed Milk";
    public override decimal Cost() => Inner.Cost() + 1.25m;
    public override int Calories() => Inner.Calories() + 80;
}

public sealed class Mocha : AddOnDecorator
{
    public Mocha(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Mocha";
    public override decimal Cost() => Inner.Cost() + 2.25m;
    public override int Calories() => Inner.Calories() + 110;
}

public sealed class Soy : AddOnDecorator
{
    public Soy(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Soy";
    public override decimal Cost() => Inner.Cost() + 1.50m;
    public override int Calories() => Inner.Calories() + 50;
}