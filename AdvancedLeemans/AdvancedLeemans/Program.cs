using AdvancedLeemans;

internal class Program
{
    private static void Main(string[] args)
    {
        var pizzaHandler = new PizzaHandler();

        MenuItem choice;
        do
        {
            choice = ShowMenu();

            try
            {
                HandleMenuChoice(choice, pizzaHandler);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}{Environment.NewLine}{Environment.NewLine}{ex.StackTrace}");
            }
        } while (choice != MenuItem.Exit);
    }

    private static MenuItem ShowMenu()
    {
        MenuItem? choice = null;
        do
        {
            Console.WriteLine("***** MENU *****");
            foreach (MenuItem menuItem in Enum.GetValues(typeof(MenuItem)))
            {
                Console.WriteLine($"{(int)menuItem} = {menuItem}");
            }
            
            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out var parsed))
            {
                if (parsed >= (int)MenuItem.AddPizza && parsed <= (int)MenuItem.Exit)
                    choice = (MenuItem)parsed;
            }
        } while (choice == null);

        return choice.Value;
    }

    private static void HandleMenuChoice(MenuItem choice, PizzaHandler pizzaHandler)
    {
        Console.WriteLine($"Processing {choice}");
        switch (choice)
        {
            case MenuItem.AddPizza:
                pizzaHandler.AddPizza();
                break;
            case MenuItem.ListPizzas:
                pizzaHandler.ListPizzas();
                break;
            case MenuItem.AddWrap:
                pizzaHandler.AddWrap();
                break;
            case MenuItem.ListWraps:
                pizzaHandler.ListWraps();
                break;
            case MenuItem.AddDrink:
                pizzaHandler.AddDrink();
                break;
            case MenuItem.ListDrinks:
                pizzaHandler.ListDrinks();
                break;
            case MenuItem.Exit:
                break;
            default:
                throw new NotImplementedException($"{choice}");
        }
    }
}