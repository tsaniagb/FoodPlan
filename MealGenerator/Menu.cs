using BMICalculator;
using GetUserData;

namespace MealPlanGenerator
{
    public class Menu
    {
        public static string GenerateMealPlan(UserData user)
        {
            double bmi = BMI.CalculateBMI(user);

            // Determine the BMI category
            string bmiCategory = GetBMICategory(bmi);

            // Generate a menu based on the BMI category
            string breakfast = GenerateBreakfast(bmiCategory);
            string lunch = GenerateLunch(bmiCategory);
            string dinner = GenerateDinner(bmiCategory);

            // Construct the complete meal plan
            return $"Breakfast:{Environment.NewLine}{breakfast}{Environment.NewLine}Lunch:{Environment.NewLine}{lunch}{Environment.NewLine}Dinner:{Environment.NewLine}{dinner}";
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

        private static string GenerateBreakfast(string bmiCategory)
        {
            // Generate breakfast menu based on BMI category
            switch (bmiCategory)
            {
                case "underweight":
                    return "Variation 1: Whole grain toast with avocado" + Environment.NewLine +
                           "Variation 2: Greek yogurt with fruits" + Environment.NewLine +
                           "Variation 3: Oatmeal with nuts";
                case "normal":
                    return "Variation 1: Scrambled eggs with vegetables" + Environment.NewLine +
                           "Variation 2: Whole grain cereal with milk" + Environment.NewLine +
                           "Variation 3: Smoothie with protein";
                case "overweight":
                    return "Variation 1: Veggie omelette" + Environment.NewLine +
                           "Variation 2: Quinoa bowl with vegetables" + Environment.NewLine +
                           "Variation 3: Low-fat cottage cheese with berries";
                default:
                    return "Invalid BMI category";
            }
        }

        private static string GenerateLunch(string bmiCategory)
        {
            // Generate lunch menu based on BMI category
            switch (bmiCategory)
            {
                case "underweight":
                    return "Variation 1: Grilled chicken salad" + Environment.NewLine +
                           "Variation 2: Quinoa and vegetable stir-fry" + Environment.NewLine +
                           "Variation 3: Lentil soup with whole grain bread";
                case "normal":
                    return "Variation 1: Grilled salmon with sweet potato" + Environment.NewLine +
                           "Variation 2: Turkey and avocado wrap" + Environment.NewLine +
                           "Variation 3: Chickpea salad with olive oil dressing";
                case "overweight":
                    return "Variation 1: Grilled vegetable and quinoa bowl" + Environment.NewLine +
                           "Variation 2: Turkey and vegetable stir-fry" + Environment.NewLine +
                           "Variation 3: Lentil and vegetable curry";
                default:
                    return "Invalid BMI category";
            }
        }

        private static string GenerateDinner(string bmiCategory)
        {
            // Generate dinner menu based on BMI category
            switch (bmiCategory)
            {
                case "underweight":
                    return "Variation 1: Baked salmon with asparagus" + Environment.NewLine +
                           "Variation 2: Spinach and feta-stuffed chicken breast" + Environment.NewLine +
                           "Variation 3: Brown rice and black bean bowl";
                case "normal":
                    return "Variation 1: Quinoa-stuffed bell peppers" + Environment.NewLine +
                           "Variation 2: Grilled shrimp with quinoa" + Environment.NewLine +
                           "Variation 3: Stir-fried tofu with broccoli";
                case "overweight":
                    return "Variation 1: Grilled chicken with roasted vegetables" + Environment.NewLine +
                           "Variation 2: Zucchini noodles with tomato sauce" + Environment.NewLine +
                           "Variation 3: Cauliflower rice with mixed vegetables";
                default:
                    return "Invalid BMI category";
            }
        }
    }
}
