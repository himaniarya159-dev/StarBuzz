namespace StarBuzz;

public enum MembershipTier
{
    Regular,    // Standard prices
    Silver,     // 10% Discount
    Gold        // 20% Discount
}

public sealed class MemberDiscount : Beverage
{
    private readonly Beverage _beverage;
    private readonly MembershipTier _tier;

    public MemberDiscount(Beverage beverage, MembershipTier tier)
    {
        _beverage = beverage;
        _tier = tier;
        Temp = beverage.Temp;
        DrinkSize = beverage.DrinkSize;
    }

    public override string Description => _tier switch
    {
        MembershipTier.Gold => $"{_beverage.Description} (Gold Member - 20% Off)",
        MembershipTier.Silver => $"{_beverage.Description} (Silver Member - 10% Off)",
        _ => _beverage.Description
    };

    public override decimal Cost()
    {
        decimal originalCost = _beverage.Cost();
        return _tier switch
        {
            MembershipTier.Gold => originalCost * 0.80m,   // 20% savings
            MembershipTier.Silver => originalCost * 0.90m, // 10% savings
            _ => originalCost
        };
    }

    public override int Calories() => _beverage.Calories(); // Calories remain unchanged
}