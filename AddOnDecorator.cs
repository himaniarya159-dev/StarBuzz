namespace StarBuzz;

public abstract class AddOnDecorator : Beverage
{
    protected readonly Beverage Inner;

    protected AddOnDecorator(Beverage inner)
    {
        Inner = inner;
        Temp = inner.Temp;
        DrinkSize = inner.DrinkSize;
    }
}