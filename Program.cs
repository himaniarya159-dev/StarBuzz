using StarBuzz;

DatabaseService.InitializeDatabase();

Order currentOrder = new Order();
bool running = true;

while (running)
{
    AppUI.ShowHome();
    string? input = Console.ReadLine()?.Trim();

    switch (input)
    {
        case "1":
            AppUI.ShowMenu();
            Console.WriteLine("\nSelect a drink number to add to cart (or press Enter to return home):");
            string? choice = Console.ReadLine()?.Trim();

            if (choice == "1")
            {
                currentOrder.AddBeverage(new Espresso(Size.Medium, Temperature.Hot));
                Console.WriteLine("\nAdded Espresso to cart! Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "2")
            {
                currentOrder.AddBeverage(new WhippedCream(new Mocha(new DarkRoast(Size.Large, Temperature.Hot))));
                Console.WriteLine("\nAdded Dark Roast w/ Mocha & Whipped Cream! Press Enter to continue...");
                Console.ReadLine();
            }
            break;

        case "2":
            AppUI.ShowCart(currentOrder);
            Console.WriteLine("\nPress Enter to return to Home Screen...");
            Console.ReadLine();
            break;

        case "3":
            AppUI.ShowCheckout();

            // Print final receipt from active cart items
            currentOrder.PrintReceipt();

            // Save order to SQLite Database
            DatabaseService.SaveOrder("StarBuzz Order Batch", 10.00m);

            // Fetch live database entries
            DatabaseService.FetchAndDisplayOrders();

            Console.WriteLine("\n=================================");
            Console.WriteLine("Press Enter to return to Home Screen...");
            Console.ReadLine();
            break;

        case "4":
            running = false;
            Console.Clear();
            Console.WriteLine("Exiting StarBuzz system. Goodbye!");
            break;

        default:
            Console.WriteLine("\nInvalid option. Press Enter to try again.");
            Console.ReadLine();
            break;
    }
}