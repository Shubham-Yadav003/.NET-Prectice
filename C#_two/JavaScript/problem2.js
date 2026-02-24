const rl = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

// Program to read student num, name, marks and calculate total, average, result and division
rl.question("Enter Student Number: ", (studNum) => {
    rl.question("Enter Student Name: ", (studName) => {
        rl.question("Enter Marks in Subject 1: ", (mark1) => {
            rl.question("Enter Marks in Subject 2: ", (mark2) => {
                rl.question("Enter Marks in Subject 3: ", (mark3) => {

                    let m1 = parseFloat(mark1);
                    let m2 = parseFloat(mark2);
                    let m3 = parseFloat(mark3);

                    let total = m1 + m2 + m3;
                    let average = total / 3;

                    let division;
                    if (average >= 75) {
                        division = "First Division";
                    } else if (average >= 60) {
                        division = "Second Division";
                    } else if (average >= 50) {
                        division = "Third Division";
                    } else {
                        division = "Fail";
                    }

                    let result = average >= 50 ? "Pass" : "Fail";

                    console.log("\n========== STUDENT RESULT ==========");
                    console.log("Student Number: " + studNum);
                    console.log("Student Name: " + studName);
                    console.log("Subject 1: " + m1);
                    console.log("Subject 2: " + m2);
                    console.log("Subject 3: " + m3);
                    console.log("Total Marks: " + total);
                    console.log("Average: " + average.toFixed(2));
                    console.log("Result: " + result);
                    console.log("Division: " + division);
                    console.log("=====================================\n");

                    rl.close();
                });
            });
        });
    });
});
