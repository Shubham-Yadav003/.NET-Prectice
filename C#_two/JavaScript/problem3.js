// 1) Welcome Message
console.log("Welcome to JavaScript Programming!\n");

// 7) Check Even or Odd
let number = 15;
let evenOrOdd = number % 2 === 0 ? "Even" : "Odd";
console.log(`${number} is ${evenOrOdd}`);

// 9) Check Positive, Negative, or Zero
let value = -25;
let checkSign = value > 0 ? "Positive" : value < 0 ? "Negative" : "Zero";
console.log(`${value} is ${checkSign}`);

// 13) Employee Salary Calculation
console.log("\nEmployee Salary Details:");
let employeeNumber = "E001";
let employeeName = "John Doe";
let baseSalary = 50000;

let providentFund = baseSalary * 0.12;
let houseRentAllowance = baseSalary * 0.20;
let deartnessAllowance = baseSalary * 0.15;

let totalGrossSalary = baseSalary + houseRentAllowance + deartnessAllowance;
let takeHomeSalary = totalGrossSalary - providentFund;

console.log(`${employeeNumber} - ${employeeName}`);
console.log(`Basic: ${baseSalary}, Gross: ${totalGrossSalary.toFixed(2)}, Net: ${takeHomeSalary.toFixed(2)}`);

// Shopping Cart - Array of Objects + For-of

let cart = [
    { item: "Laptop", price: 50000 },
    { item: "Mouse", price: 500 },
    { item: "Keyboard", price: 1500 }
];

console.log("\nItems:");
for (let product of cart) {
    console.log(`• ${product.item}: ₹${product.price}`);
}

let total = 0;
for (let product of cart) {
    total += product.price;
}

let gst = total * 0.18;
let finalPrice = total + gst;

console.log(`\nTotal: ₹${total}`);
console.log(`GST (18%): ₹${gst.toFixed(2)}`);
console.log(`Final Price: ₹${finalPrice.toFixed(2)}`);