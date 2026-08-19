using StarBuzz;

// Create a new multi-drink order
Order order = new Order();

// Drink 1: Large Hot Dark Roast with Mocha & Whipped Cream ($5.25)
Beverage drink1 = 
    new WhippedCream(
        new Mocha(
            new DarkRoast(Size.Large, Temperature.Hot)));

// Drink 2: Medium Iced Espresso with Soy & Vanilla ($3.55)
Beverage drink2 = 
    new Vanilla(
        new SoyMilk(
            new Espresso(Size.Medium, Temperature.Iced)));

// Add both coffees to the order
order.AddBeverage(drink1);
order.AddBeverage(drink2);

// Print itemized receipt with BOGO 20% discount applied to the 2nd drink
order.PrintReceipt();