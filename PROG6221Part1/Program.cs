using System;

class Ingredient
{
    public string Name { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }
}

class Step
{
    public string Description { get; set; }
}

class Recipe
{
    private Ingredient[] ingredients;
    private Step[] steps;

    public void AddIngredients(int numberOfIngredients)
    {
        ingredients = new Ingredient[numberOfIngredients];
        for (int i = 0; i < numberOfIngredients; i++)
        {
            Console.WriteLine($"Enter name for ingredient {i + 1}: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter quantity for ingredient {i + 1}: ");
            double quantity = double.Parse(Console.ReadLine());
            Console.WriteLine($"Enter unit for ingredient {i + 1}: ");
            string unit = Console.ReadLine();
            ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
        }
    }

    public void AddSteps(int numberOfSteps)
    {
        steps = new Step[numberOfSteps];
        for (int i = 0; i < numberOfSteps; i++)
        {
            Console.WriteLine($"Enter step {i + 1}: ");
            string description = Console.ReadLine();
            steps[i] = new Step { Description = description };
        }
    }

    public void DisplayRecipe()
    {
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
        }

        Console.WriteLine("\nSteps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i].Description}");
        }
    }

    public void ScaleRecipe(double factor)
    {
        foreach (var ingredient in ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }

    public void ResetQuantities()
    {
        // Implement resetting quantities to original values
    }

    public void ClearRecipe()
    {
        // Implement clearing all data to enter a new recipe
    }
}

class Program
{
    static void Main(string[] args)
    {
        Recipe recipe = new Recipe();

        Console.WriteLine("Enter the number of ingredients: ");
        int numberOfIngredients = int.Parse(Console.ReadLine());
        recipe.AddIngredients(numberOfIngredients);

        Console.WriteLine("Enter the number of steps: ");
        int numberOfSteps = int.Parse(Console.ReadLine());
        recipe.AddSteps(numberOfSteps);

        recipe.DisplayRecipe();

        // Handle scaling, resetting, and clearing as per user input
    }
}