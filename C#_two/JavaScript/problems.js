// const readline = require('readline');

const rl = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

// 3) Program to read a floating point number from user
console.log("Program to read a floating point number");
rl.question("Enter a floating point number: ", (input) => {
    let num = parseFloat(input);
    console.log("You entered:", num);
    console.log("Type:", typeof num);

    // 4) Program to read a string from user and display it on the screen
    console.log("\nProgram to read a string from user");
    rl.question("Enter a string: ", (str) => {
        console.log("You entered:", str);
        console.log("String length:", str.length);
        console.log("Uppercase:", str.toUpperCase());
        rl.close();
    });
});


