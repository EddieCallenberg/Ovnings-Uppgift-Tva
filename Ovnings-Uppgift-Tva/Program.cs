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
            int switchSelector = Convert.ToInt32(Console.ReadLine());

            switch (switchSelector)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Please enter what you would like to add to your shoppinglist.");
                    string newItem = Console.ReadLine();
                    if(string.IsNullOrEmpty(newItem))
                    {
                        Console.WriteLine("Cannot be empty. Please try again");
                    }
                    shoppingList.Add(newItem);
                    Console.WriteLine($"You added {shoppingList.LastOrDefault()} to the shoppinglist");
                    break;
            }
        }
        

    }
}