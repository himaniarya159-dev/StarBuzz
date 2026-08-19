namespace StarBuzz;

public class Order
{
    private readonly List<Beverage> _items = new();

    public void AddBeverage(Beverage beverage) => _items.Add(beverage);

    public decimal CalculateTotal(out decimal originalTotal, out decimal savings)
    {
        originalTotal = _items.Sum(item => item.Cost());
        
        // If 2 or more drinks are purchased, apply 20% discount to the 2nd drink (cheaper one)
        if (_items.Count >= 2)
        {
            var sortedByPrice = _items.OrderByDescending(item => item.Cost()).ToList();
            
            // Discount 20% off the second drink
            decimal secondDrinkCost = sortedByPrice[1].Cost();
            savings = secondDrinkCost * 0.20m;
        }
        else
        {
            savings = 0.00m;
        }

        return originalTotal - savings;
    }

    public void PrintReceipt()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("        STARBUZZ RECEIPT         ");
        Console.WriteLine("=================================\n");

        for (int i = 0; i < _items.Count; i++)
        {
            Console.WriteLine($"Item {i + 1}: {_items[i].Description}");
            Console.WriteLine($"         Calories: {_items[i].Calories()} kcal | Price: ${_items[i].Cost():0.00}");
        }

        Console.WriteLine("\n---------------------------------");
        decimal total = CalculateTotal(out decimal originalTotal, out decimal savings);
        
        Console.WriteLine($"Subtotal:             ${originalTotal:0.00}");
        
        if (savings > 0)
        {
            Console.WriteLine($"2-Drink Offer (20% off 2nd): -${savings:0.00}");
        }
        
        Console.WriteLine($"Final Total:          ${total:0.00}");
        Console.WriteLine("=================================\n");
    }
}