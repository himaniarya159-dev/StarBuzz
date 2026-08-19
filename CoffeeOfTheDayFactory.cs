namespace StarBuzz;

public static class CoffeeOfTheDayFactory
{
    public static Beverage GetCoffeeOfTheDay()
    {
        DayOfWeek today = DateTime.Now.DayOfWeek;

        return today switch
        {
            DayOfWeek.Monday => 
                new Caramel(new SteamedMilk(new HouseBlend(Size.Medium, Temperature.Hot))),

            DayOfWeek.Tuesday => 
                new ChocoSauce(new Mocha(new DarkRoast(Size.Medium, Temperature.Hot))),

            DayOfWeek.Wednesday => 
                new Vanilla(new Soy(new Espresso(Size.Medium, Temperature.Iced))),

            DayOfWeek.Thursday => 
                new WhippedCream(new SteamedMilk(new Decaf(Size.Medium, Temperature.Hot))),

            DayOfWeek.Friday => 
                new WhippedCream(new Caramel(new Mocha(new DarkRoast(Size.Large, Temperature.Hot)))),

            _ => new SteamedMilk(new HouseBlend(Size.Medium, Temperature.Hot))
        };
    }
}