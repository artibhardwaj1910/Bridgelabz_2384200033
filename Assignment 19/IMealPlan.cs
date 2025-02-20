using System;
namespace GenericsAssignment{
public interface IMealPlan
{
    string GetMealDescription();
    bool IsValid();
}

public class VegetarianMeal : IMealPlan
{
    public string GetMealDescription()
    {
        return "A healthy vegetarian meal plan.";
    }

    public bool IsValid()
    {
        return true;
    }
}

public class VeganMeal : IMealPlan
{
    public string GetMealDescription()
    {
        return "A nutritious vegan meal plan.";
    }

    public bool IsValid()
    {
        return true;
    }
}

public class KetoMeal : IMealPlan
{
    public string GetMealDescription()
    {
        return "A low-carb, high-fat Keto meal plan.";
    }

    public bool IsValid()
    {
        return true;
    }
}

public class HighProteinMeal : IMealPlan
{
    public string GetMealDescription()
    {
        return "A high-protein meal plan to build muscle.";
    }

    public bool IsValid()
    {
        return true;
    }
}

public class Meal<T> where T : IMealPlan
{
    private T _mealPlan;

    public Meal(T mealPlan)
    {
        _mealPlan = mealPlan;
    }

    public string GetMealDetails()
    {
        return _mealPlan.GetMealDescription();
    }

    public bool ValidateMealPlan()
    {
        return _mealPlan.IsValid();
    }
}

public class MealPlanGenerator
{
    public Meal<T> GenerateMealPlan<T>(T mealPlan) where T : IMealPlan
    {
        if (mealPlan.IsValid())
        {
            return new Meal<T>(mealPlan);
        }
        else
        {
            throw new InvalidOperationException("Invalid meal plan.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MealPlanGenerator generator = new MealPlanGenerator();

        VegetarianMeal vegetarianMeal = new VegetarianMeal();
        Meal<VegetarianMeal> vegetarian = generator.GenerateMealPlan(vegetarianMeal);
        Console.WriteLine("Vegetarian Meal: " + vegetarian.GetMealDetails());

        VeganMeal veganMeal = new VeganMeal();
        Meal<VeganMeal> vegan = generator.GenerateMealPlan(veganMeal);
        Console.WriteLine("Vegan Meal: " + vegan.GetMealDetails());

        KetoMeal ketoMeal = new KetoMeal();
        Meal<KetoMeal> keto = generator.GenerateMealPlan(ketoMeal);
        Console.WriteLine("Keto Meal: " + keto.GetMealDetails());

        HighProteinMeal highProteinMeal = new HighProteinMeal();
        Meal<HighProteinMeal> highProtein = generator.GenerateMealPlan(highProteinMeal);
        Console.WriteLine("High-Protein Meal: " + highProtein.GetMealDetails());
    }
}

}