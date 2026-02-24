// area of circle !! 
var readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

readline.question('Please enter Radius: ', radius => {
    var area = 3.14 * radius * radius;
    console.log(`Area , ${area}!`);
    readline.close();
})