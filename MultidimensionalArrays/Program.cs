Dictionary<string, Queue<DateTime>> Ingredients = new Dictionary<string, Queue<DateTime>>();

bool continueRunning = true;

while(continueRunning)
{
    Console.WriteLine("1. Add or 2. Remove Ingredients");
    int addOrRemoveInput = Int32.Parse(Console.ReadLine());

    if(addOrRemoveInput == 1)
    {
        // === ADD INGREDIENTS ===
        #region
        Console.WriteLine("Please enter your Ingredient to add, or STOP to end: ");
        string ingredientName = Console.ReadLine().ToUpper();

        while (ingredientName != "STOP")
        {
            while (ingredientName.Length < 3)
            {
                Console.WriteLine("Enter a minimum of three characters.");
                ingredientName = Console.ReadLine().ToUpper();
            }

            if (!Ingredients.ContainsKey(ingredientName))
            {
                Ingredients.Add(ingredientName, new Queue<DateTime>());
            }

            Ingredients[ingredientName].Enqueue(DateTime.Now);

            Console.WriteLine("Please enter your Ingredient to add: ");
            ingredientName = Console.ReadLine().ToUpper();
        }
        #endregion

    } else if (addOrRemoveInput == 2)
    {
        // REMOVE INGREDIENT
        #region
        Console.WriteLine("Enter the name of the ingredient you want to remove, or STOP to stop removing items: ");
        string removeInput = Console.ReadLine().ToUpper();

        while (removeInput != "STOP")
        {
            if (!Ingredients.ContainsKey(removeInput))
            {
                Console.WriteLine($"No ingredient found with name {removeInput}");
            }
            else
            {
                DateTime removedDate = Ingredients[removeInput].Dequeue();
                Console.WriteLine($"Removed {removeInput} with entry date {removedDate.ToString()}");
            }

            Console.WriteLine("Enter an item name to remove");
            removeInput = Console.ReadLine().ToUpper();
        }

        #endregion
    } else
    {
        Console.WriteLine("Invalid choice.");

        Console.WriteLine("1. Add or 2. Remove Ingredients");
        addOrRemoveInput = Int32.Parse(Console.ReadLine());
    }
}