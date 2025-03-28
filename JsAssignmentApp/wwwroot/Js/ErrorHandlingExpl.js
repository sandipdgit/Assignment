/**
 * ************************************************************************************************************
 * Write a program and implement error handling in JavaScript.
 * ************************************************************************************************************
 */

// Basic JavaScript program with error handling

function divideNumbers(a, b) {
    try {
        if (typeof a !== 'number' || typeof b !== 'number') {
            throw new TypeError('Both arguments must be numbers.');
        }
        if (b === 0) {
            throw new Error('Division by zero is not allowed.');
        }
        let result = a / b;
        console.log(`Result: ${result}`);
    } catch (error) {
        console.error(`Error: ${error.message}`);
    } finally {
        console.log('Execution completed.');
    }
}

// Test cases
console.log('Output : ', divideNumbers(10, 2), '\n');  // Valid input
console.log('Output : ', divideNumbers(10, 0), '\n');  // Division by zero
console.log('Output : ', divideNumbers(10, 'a'), '\n'); // Invalid type

/*************************************************************************************** */

// Custom Error Example
class CustomError extends Error {
    constructor(message) {
        super(message);
        this.name = 'CustomError';
    }
}

function checkPositive(num) {
    if (num < 0) {
        throw new CustomError('Number must be positive');
    }
    return 'Number is positive';
}

try {
    console.log(checkPositive(5));
    console.log(checkPositive(-5));
} catch (error) {
    console.error(`${error.name}: ${error.message}`);
}

/*************************************************************************************** */