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

            const roundedBMI = bmiResult.toFixed(2);
            // Displaying the BMI information in the result section
            const resultElement = document.getElementById("result");
            resultElement.innerHTML = `
                <p>BMI Result: ${roundedBMI}</p>
                <p>BMI Category: ${bmiCategory}</p>
            `;

            // Displaying the food recommendation in the foodRecommendation section
            const foodRecommendationElement = document.getElementById("foodRecommendation");

            // Replace line breaks with HTML line break tags
            const formattedMealPlan = detailedMealPlan.replace(/\n/g, '<br>');

            // Display the formatted meal plan
            foodRecommendationElement.innerHTML = `
                <p>Menu Recommendation</p>
                <div>${formattedMealPlan}</div>
            `;
        })
        .catch(error => {
            console.error("Error fetching API:", error);
            document.getElementById("result").innerHTML = `Error fetching API: ${error.message}`;
        });
});