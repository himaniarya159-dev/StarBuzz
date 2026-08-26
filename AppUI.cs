namespace StarBuzz;

public static class AppUI
{
    public static void ShowHome()
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("    STARBUZZ - HOME SCREEN       ");
        Console.WriteLine("=================================");
        Console.WriteLine("1. View Beverage Menu");
        Console.WriteLine("2. View Cart");
        Console.WriteLine("3. View Checkout & Print Receipt");
        Console.WriteLine("4. Exit Application");
        Console.WriteLine("=================================");
        Console.Write("Select an option (1-4): ");
    }

    public static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("    SCREEN 2: BEVERAGE MENU      ");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Espresso        - $2.00");
        Console.WriteLine("2. Dark Roast      - $3.00");
        Console.WriteLine("3. House Blend     - $2.00");
        Console.WriteLine("4. Decaf           - $2.00");
        Console.WriteLine("=================================");
    }

    public static void ShowCart(Order currentOrder)
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("    SCREEN 3: YOUR CART          ");
        Console.WriteLine("=================================");
        currentOrder.PrintReceipt();
        Console.WriteLine("=================================");
    }

    public static void ShowCheckout()
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("    SCREEN 4: CHECKOUT & RECEIPT ");
        Console.WriteLine("=================================");
    }
}