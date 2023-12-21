document.getElementById("submitBtn").addEventListener("click", function () {
    var userData = {
        Name: document.getElementById("nameInput").value,
        Age: parseInt(document.getElementById("ageInput").value),
        Height: parseFloat(document.getElementById("heightInput").value),
        Weight: parseFloat(document.getElementById("weightInput").value)
    };

    console.log("Sending API request with user data:", userData);

    fetch("/api/FoodPlan", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(userData)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error(`HTTP error! Status: ${response.status}`);
            }
            return response.json();
        })
        .then(data => {
            console.log("Received API response:", data);

            // Extracting relevant information from the API response
            const bmiResult = data.bmi;
            const bmiCategory = data.bmiCategory;
            const detailedMealPlan = data.detailedMealPlan;

            // Displaying the BMI information in the result section
            const resultElement = document.getElementById("result");
            resultElement.innerHTML = `
            <p>BMI Result: ${data.bmi}</p>
            <p>BMI Category: ${data.bmiCategory}</p>
        `;

            // Displaying the food recommendation in the foodRecommendation section
            const foodRecommendationElement = document.getElementById("foodRecommendation");
            foodRecommendationElement.innerHTML = `
            <p>Food Recommendation: ${data.detailedMealPlan}</p>
        `;
        })
        .catch(error => {
            console.error("Error fetching API:", error);
            document.getElementById("result").innerHTML = "Error fetching API";
        });

});
