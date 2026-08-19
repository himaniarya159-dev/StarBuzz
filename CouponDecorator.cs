namespace StarBuzz;

public sealed class CouponDecorator : Beverage
{
    private readonly Beverage _beverage;
    private readonly string _code;

    public CouponDecorator(Beverage beverage, string code)
    {
        _beverage = beverage;
        _code = code;
        Temp = beverage.Temp;
        DrinkSize = beverage.DrinkSize;
    }

    public static bool IsValidCoupon(string code) =>
        string.Equals(code, "COFFEE10", StringComparison.OrdinalIgnoreCase);

    public static decimal ApplyCoupon(string code, decimal currentTotal)
    {
        if (IsValidCoupon(code))
        {
            // Deduct $1.00, ensuring the total never drops below $0.00
            return Math.Max(0.00m, currentTotal - 1.00m);
        }

        return currentTotal;
    }

    public override string Description => IsValidCoupon(_code)
        ? $"{_beverage.Description} (Coupon '{_code.ToUpper()}' -$1.00)"
        : $"{_beverage.Description} (Invalid Coupon)";

    public override decimal Cost()
    {
        decimal currentTotal = _beverage.Cost();
        return ApplyCoupon(_code, currentTotal);
    }

    public override int Calories() => _beverage.Calories();
}