let a = 10;
let b = 5;
let addition = a + b;
let subtraction = a - b;
let multiplication = a * b;
let division = a / b;
let modulus = a % b;

console.log("Addition:", addition);
console.log("Subtraction:", subtraction);
console.log("Multiplication:", multiplication);
console.log("Division:", division);
console.log("Modulus:", modulus);



//program to calculate area of circle
let radius = 7;
let area = Math.PI * radius * radius;
console.log("Area of the circle with radius", radius, "is:", area);



//find out greatest of two numbers
let num1 = 15;
let num2 = 20;
if (num1 > num2) {
    console.log(num1, "is greater than", num2);
}
else if (num2 > num1) {
    console.log(num2, "is greater than", num1);
}
else {
    console.log("Both numbers are equal.");
}



//find out greatest of three numbers
let x = 25;
let y = 30;
let z = 20;
if (x > y && x > z) {
    console.log(x, "is the greatest number.");
}
else if (y > x && y > z) {
    console.log(y, "is the greatest number.");
}
else if (z > x && z > y) {
    console.log(z, "is the greatest number.");
}





//greatest of three numbers using nested if
let p = 12;
let q = 18;
let r = 10;


if (p > q) {
    if (p > r) {
        console.log(p, "is the greatest number.");
    }
    else {
        console.log(r, "is the greatest number.");
    }
}
else {
    if (q > r) {
        console.log(q, "is the greatest number.");
    }
    else {
        console.log(r, "is the greatest number.");
    }
}

// switch case 

var operator = '+';
var num = 10;
var num = 5;
var result;
switch (operator) {
    case '+':
        result = num + num;
        break;

    case '-':
        result = num - num;
        break;
    case '*':
        result = num * num;
        break;
    case '/':
        result = num / num;
        break;
    default:
        console.log("Invalid operator");
        break;
}

// create an array and print using foreach loop
let fruits = ["Apple", "Banana", "Cherry", "Date", "Elderberry"];
fruits.forEach(element => console.log(element));

//loop through all the propeties in the object
var person = {"name": "John", "age": 30, "city": "New York"};
for (let key in person) {
    console.log(key + ": " + person[key]);
}

// iterate an array
let letters = ["A", "B", "C", "D", "E"];
for(var letter of letters) {
    console.log(letter);
}