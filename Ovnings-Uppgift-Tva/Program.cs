internal class Program
{
    private static void Main(string[] args)
    {
        List<string> shoppingList = new List<string>();
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Hello, User!");
            Console.WriteLine("1. - Add Items to your Shopping List.");
            Console.WriteLine("2. - View your Shopping List.");
            Console.WriteLine("3. - Exit");
            int switchSelector = Convert.ToInt32(Console.ReadLine());

            switch (switchSelector)
            {
                case 1:
                    AddToShoppingList(shoppingList);
                    break;
                case 2:
                    PrintShoppingList(shoppingList);
                    break;
                case 3:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, try again");
                    break;
            }
        }
    }
    public static void AddToShoppingList(List<string> shoppingList)
    {
        Console.Clear();
        Console.WriteLine("Please enter what you would like to add to your shopping list.");
        string? newItem = Console.ReadLine();

        if (string.IsNullOrEmpty(newItem))
        {
            Console.WriteLine("Cannot be empty. Please try again.");
        }
        else
        {
            shoppingList.Add(newItem);
            Console.WriteLine($"You added {shoppingList.LastOrDefault()} to the shopping list.");
        }

        Console.WriteLine("Do you wish to add another item?");
        Console.WriteLine("1. - Yes");
        Console.WriteLine("2. - No");
        int switchSelectorTwo = Convert.ToInt32(Console.ReadLine());
        switch (switchSelectorTwo)
        {
            case 1:
                AddToShoppingList(shoppingList);
                break;
            case 2:
                break;
        }
    }

    public static void PrintShoppingList(List<string> shoppingList)
    {
        Console.Clear();

        if (shoppingList.Count == 0)
        {
            Console.WriteLine("Your shopping list is empety");
        }
        else
        {
            Console.WriteLine("Your shopping list:");
            foreach (var item in shoppingList)
            {
                Console.WriteLine(item);
            }
        }
    }
}