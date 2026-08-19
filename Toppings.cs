namespace StarBuzz;

public sealed class WhippedCream : AddOnDecorator
{
    public WhippedCream(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Whipped Cream";
    public override decimal Cost() => Inner.Cost() + 0.50m;
    public override int Calories() => Inner.Calories() + 110;
}

public sealed class ChocoSauce : AddOnDecorator
{
    public ChocoSauce(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Choco Sauce";
    public override decimal Cost() => Inner.Cost() + 0.75m;
    public override int Calories() => Inner.Calories() + 90;
}

public sealed class Caramel : AddOnDecorator
{
    public Caramel(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Caramel";
    public override decimal Cost() => Inner.Cost() + 0.30m;
    public override int Calories() => Inner.Calories() + 60;
}

public sealed class Vanilla : AddOnDecorator
{
    public Vanilla(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Vanilla";
    public override decimal Cost() => Inner.Cost() + 0.25m;
    public override int Calories() => Inner.Calories() + 50;
}