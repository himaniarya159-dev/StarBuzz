namespace StarBuzz;

public sealed class WholeMilk : AddOnDecorator
{
    public WholeMilk(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Whole Milk";
    public override decimal Cost() => Inner.Cost() + 0.50m;
    public override int Calories() => Inner.Calories() + 100;
}

public sealed class LactoseFreeMilk : AddOnDecorator
{
    public LactoseFreeMilk(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Lactose-Free Milk";
    public override decimal Cost() => Inner.Cost() + 0.75m;
    public override int Calories() => Inner.Calories() + 90;
}

public sealed class AlmondMilk : AddOnDecorator
{
    public AlmondMilk(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Almond Milk";
    public override decimal Cost() => Inner.Cost() + 1.00m;
    public override int Calories() => Inner.Calories() + 40;
}

public sealed class SoyMilk : AddOnDecorator
{
    public SoyMilk(Beverage inner) : base(inner) { }
    public override string Description => $"{Inner.Description}, Soy Milk";
    public override decimal Cost() => Inner.Cost() + 0.80m;
    public override int Calories() => Inner.Calories() + 80;
}