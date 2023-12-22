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
            return $"\nBreakfast:\n{breakfast}\n\n\n\nLunch:\n{lunch}\n\n\n\nDinner:\n{dinner}";
        }

        public static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi < 25)
            {
                return "Normal";
            }
            else
            {
                return "Overweight";
            }
        }

        private static string GenerateBreakfast(string bmiCategory)
        {
            // Generate breakfast menu based on BMI category
            switch (bmiCategory)
            {
                case "Underweight":
                    return "Variation 1: Whole grain toast with avocado\nVariation 2: Greek yogurt with fruits\nVariation 3: Oatmeal with nuts";
                case "Normal":
                    return "Variation 1: Scrambled eggs with vegetables\nVariation 2: Whole grain cereal with milk\nVariation 3: Smoothie with protein";
                case "Overweight":
                    return "Variation 1: Veggie omelette\nVariation 2: Quinoa bowl with vegetables\nVariation 3: Low-fat cottage cheese with berries";
                default:
                    return "Invalid BMI category";
            }
        }

        private static string GenerateLunch(string bmiCategory)
        {
            // Generate lunch menu based on BMI category
            switch (bmiCategory)
            {
                case "Underweight":
                    return "Variation 1: Grilled chicken salad\nVariation 2: Quinoa and vegetable stir-fry\nVariation 3: Lentil soup with whole grain bread";
                case "Normal":
                    return "Variation 1: Grilled salmon with sweet potato\nVariation 2: Turkey and avocado wrap\nVariation 3: Chickpea salad with olive oil dressing";
                case "Overweight":
                    return "Variation 1: Grilled vegetable and quinoa bowl\nVariation 2: Turkey and vegetable stir-fry\nVariation 3: Lentil and vegetable curry";
                default:
                    return "Invalid BMI category";
            }
        }

        private static string GenerateDinner(string bmiCategory)
        {
            // Generate dinner menu based on BMI category
            switch (bmiCategory)
            {
                case "Underweight":
                    return "Variation 1: Baked salmon with asparagus\nVariation 2: Spinach and feta-stuffed chicken breast\nVariation 3: Brown rice and black bean bowl";
                case "Normal":
                    return "Variation 1: Quinoa-stuffed bell peppers\nVariation 2: Grilled shrimp with quinoa\nVariation 3: Stir-fried tofu with broccoli";
                case "Overweight":
                    return "Variation 1: Grilled chicken with roasted vegetables\nVariation 2: Zucchini noodles with tomato sauce\nVariation 3: Cauliflower rice with mixed vegetables";
                default:
                    return "Invalid BMI category";
            }
        }
    }
}
