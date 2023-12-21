using BMICalculator;
using GetUserData;

public class Menu
{
    public static string GenerateMealPlan(UserData user)
    {
        double bmi = BMI.CalculateBMI(user);

        // Determine the BMI category
        string bmiCategory = GetBMICategory(bmi);

        // Generate a menu based on the BMI category
        string breakfast = GenerateMealCategory("Breakfast", GetBreakfastVariations(bmiCategory));
        string lunch = GenerateMealCategory("Lunch", GetLunchVariations(bmiCategory));
        string dinner = GenerateMealCategory("Dinner", GetDinnerVariations(bmiCategory));

        // Construct the complete meal plan
        return $"{breakfast}\r\n{lunch}\r\n{dinner}";
    }
    public static string GetBMICategory(double bmi)
    {
        if (bmi < 18.5)
        {
            return "underweight";
        }
        else if (bmi < 25)
        {
            return "normal";
        }
        else
        {
            return "overweight";
        }
    }

    private static string GenerateMealCategory(string category, string[] variations)
    {
        return $"{category}:\r\n{string.Join("\r\n", variations.Select(v => $"- {v}"))}";
    }

    private static string[] GetBreakfastVariations(string bmiCategory)
    {
        // Generate breakfast menu based on BMI category
        switch (bmiCategory)
        {
            case "underweight":
                return new[] { "Whole grain toast with avocado", "Greek yogurt with fruits", "Oatmeal with nuts" };
            case "normal":
                return new[] { "Scrambled eggs with vegetables", "Whole grain cereal with milk", "Smoothie with protein" };
            case "overweight":
                return new[] { "Veggie omelette", "Quinoa bowl with vegetables", "Low-fat cottage cheese with berries" };
            default:
                return new[] { "Invalid BMI category" };
        }
    }

    private static string[] GetLunchVariations(string bmiCategory)
    {
        // Generate lunch menu based on BMI category
        switch (bmiCategory)
        {
            case "underweight":
                return new[] { "Grilled chicken salad", "Quinoa and vegetable stir-fry", "Lentil soup with whole grain bread" };
            case "normal":
                return new[] { "Grilled salmon with sweet potato", "Turkey and avocado wrap", "Chickpea salad with olive oil dressing" };
            case "overweight":
                return new[] { "Grilled vegetable and quinoa bowl", "Turkey and vegetable stir-fry", "Lentil and vegetable curry" };
            default:
                return new[] { "Invalid BMI category" };
        }
    }

    private static string[] GetDinnerVariations(string bmiCategory)
    {
        // Generate dinner menu based on BMI category
        switch (bmiCategory)
        {
            case "underweight":
                return new[] { "Baked salmon with asparagus", "Spinach and feta-stuffed chicken breast", "Brown rice and black bean bowl" };
            case "normal":
                return new[] { "Quinoa-stuffed bell peppers", "Grilled shrimp with quinoa", "Stir-fried tofu with broccoli" };
            case "overweight":
                return new[] { "Grilled chicken with roasted vegetables", "Zucchini noodles with tomato sauce", "Cauliflower rice with mixed vegetables" };
            default:
                return new[] { "Invalid BMI category" };
        }
    }

    // ... (rest of the class remains unchanged)
}
