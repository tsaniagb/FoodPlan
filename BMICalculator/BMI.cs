using GetUserData;

namespace BMICalculator
{
    public class BMI
    {
            public static double CalculateBMI(UserData user)
            {
                double heightInMeters = user.Height / 100;
                double bmi = user.Weight / (heightInMeters * heightInMeters);
                return bmi;
            }
        }
    }

