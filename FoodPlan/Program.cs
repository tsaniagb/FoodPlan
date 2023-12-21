using GetUserData;
using BMICalculator;

class Program
{
    static void Main()
    {
        UserData user = GetUserDataFromUser();
        double bmi = BMI.CalculateBMI(user);

        string bmiCategory = Menu.GetBMICategory(bmi);
        string detailedMealPlan = Menu.GenerateMealPlan(user);

        DisplayResults(user, bmi, bmiCategory, detailedMealPlan);
    }

    static UserData GetUserDataFromUser()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your height in centimeters: ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Enter your weight in kilograms: ");
        double weight = double.Parse(Console.ReadLine());

        return new UserData { Name = name, Age = age, Height = height, Weight = weight };
    }

    static void DisplayResults(UserData user, double bmi, string bmiCategory, string detailedMealPlan)
    {
        Console.WriteLine($"{user.Name}'s BMI: {bmi}");
        Console.WriteLine($"BMI Category: {bmiCategory}");
        Console.WriteLine("Recommended Meal Plan:");
        Console.WriteLine(detailedMealPlan);
    }
}