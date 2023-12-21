using BMICalculator;
using GetUserData;
using MealPlanGenerator;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class FoodPlanController : ControllerBase
{
    [HttpPost]
    public ActionResult<FoodPlanResponse> GenerateFoodPlan([FromBody] UserData userData)
    {
        // Call your existing logic from Program.cs
        UserData user = userData;
        double bmi = BMI.CalculateBMI(user);
        string bmiCategory = Menu.GetBMICategory(bmi);
        string detailedMealPlan = Menu.GenerateMealPlan(user);

        // Create a new class to represent the response
        var response = new FoodPlanResponse
        {
            BMI = bmi,
            BMICategory = bmiCategory,
            DetailedMealPlan = detailedMealPlan
        };

        return Ok(response);
    }
}

// Create a new class to represent the response structure
public class FoodPlanResponse
{
    public double BMI { get; set; }
    public string BMICategory { get; set; }
    public string DetailedMealPlan { get; set; }
}
