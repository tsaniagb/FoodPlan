using BMICalculator;
using GetUserData;

namespace BMICalculatorTest
{
    [TestClass]
    public class BMITest
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserData user = new UserData
            {
                Height = 175,
                Weight = 70
            };

            double bmi = BMI.CalculateBMI(user);

            Assert.AreEqual(22.857142, bmi, 0.001);
        }
    }
} 
