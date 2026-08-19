# StarBuzz Coffee Ordering System

A C# console application simulating a flexible coffee ordering platform built using Object-Oriented Design Patterns.

## Features
- **Decorator Pattern:** Dynamic addition of milk varieties (Almond, Soy, Lactose-Free), spices, and toppings to base beverages.
- **Factory Pattern:** Automatically generates a customized "Coffee of the Day" based on the day of the week.
- **Customizations:** Full support for drink sizing (Small, Medium, Large), temperatures (Hot, Iced), and dynamic calorie calculations.
- **Discounts & Promotions:** 
  - Tiered membership discounts (Silver & Gold).
  - Promo code verification (`COFFEE10` for $1.00 off).
  - Multi-drink orders with 20% off the second beverage.

## Project Structure
- `Beverage.cs`: Abstract base class and core enums (Size, Temperature).
- `Coffees.cs`: Concrete base beverages (`Espresso`, `DarkRoast`, `HouseBlend`, `Decaf`).
- `AddOnDecorator.cs`: Base class for decorator layers.
- `MilkDecorators.cs`, `Spices.cs`, `Toppings.cs`: Decorator implementations.
- `Membership.cs` & `CouponDecorator.cs`: Pricing rules and promotional logic.
- `CoffeeOfTheDayFactory.cs`: Daily special factory.
- `Order.cs`: Order processor and receipt generator.