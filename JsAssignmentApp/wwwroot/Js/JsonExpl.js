/*********************************************************************************** */
/*
Write a program in JavaScript which explains the use of JSON.stringify and JSON.parse
*/
/*********************************************************************************** */

// Demonstration of JSON.stringify and JSON.parse in JavaScript

// Example object
const user = {
    name: "Alice",
    age: 25,
    isActive: true,
    hobbies: ["reading", "traveling", "coding"],
    address: {
        street: "123 Main St",
        city: "Wonderland"
    }
};

// JSON.stringify - Convert JavaScript object to JSON string
const jsonString = JSON.stringify(user);
console.log("JSON String:", jsonString);

// JSON.stringify with spacing for readability
const prettyJsonString = JSON.stringify(user, null, 4);
console.log("Pretty JSON String:\n", prettyJsonString);

// JSON.parse - Convert JSON string back to JavaScript object
const parsedObject = JSON.parse(jsonString);
console.log("Parsed Object:", parsedObject);

// Accessing properties after parsing
console.log("User's name:", parsedObject.name);
console.log("User's hobbies:", parsedObject.hobbies);

// Error handling in JSON.parse
try {
    JSON.parse("Invalid JSON string");
} catch (error) {
    console.error("Error parsing JSON:", error.message);
}
