/*********************************************************************************** */
/*
Write the program to deep copy and shallow copy objects with all possible scenario 
(simple object / object with nested object / Objects with method / dates etc.) 
*/
/*********************************************************************************** */

//Employee Data
let employee = {
    eid: "E102",
    ename: "Jack",
    eaddress: "New York",
    salary: 50000
}

// A) Shallow Copy Example
function fnShallowCopy() {
    console.log("\n\n");
    console.log("=========Shallow Copy Example========");
    console.log("Employee=> ", employee);
    let newEmployee = employee;    // Shallow copy
    console.log("New Employee=> ", newEmployee);

    console.log("---------After modification----------");
    newEmployee.ename = "Beck";
    console.log("Employee=> ", employee);
    console.log("New Employee=> ", newEmployee); // Name of the employee as well as newEmployee is changed.
}

fnShallowCopy();

/*********************************************************************************** */

// B) Deep Copy Example
function fnDeepCopy() {
    console.log("\n\n");
    console.log("=========Deep Copy Example========");
    let newEmployee = JSON.parse(JSON.stringify(employee));
    console.log("Employee=> ", employee);
    console.log("New Employee=> ", newEmployee);

    console.log("---------After modification---------");
    newEmployee.ename = "Beck";
    newEmployee.salary = 70000;
    console.log("Employee=> ", employee);
    console.log("New Employee=> ", newEmployee);
}

fnDeepCopy();

/*********************************************************************************** */
//Sample Programs
/*********************************************************************************** */

// Shallow Copy Function
function shallowCopy(obj) {
    return Object.assign({}, obj);
}

// Deep Copy Function
function deepCopy(obj) {
    return JSON.parse(JSON.stringify(obj));
}



// Example 1: Simple Object
console.log("\n\n");
console.log("=========Example 1: Simple Object========");
const simpleObj = { a: 1, b: 2 };
const shallowSimple = shallowCopy(simpleObj);
const deepSimple = deepCopy(simpleObj);
simpleObj.a = 100;
console.log('Shallow Simple:', shallowSimple); // { a: 1, b: 2 }
console.log('Deep Simple:', deepSimple);     // { a: 1, b: 2 }



// Example 2: Nested Object
console.log("\n\n");
console.log("=========Example 2: Nested Object========");
const nestedObj = { a: 1, b: { c: 2 } };
const shallowNested = shallowCopy(nestedObj);
const deepNested = deepCopy(nestedObj);
nestedObj.b.c = 100;
console.log('Shallow Nested:', shallowNested); // { a: 1, b: { c: 100 } }
console.log('Deep Nested:', deepNested);       // { a: 1, b: { c: 2 } }



// Example 3: Object with Methods
console.log("\n\n");
console.log("=========Example 3: Object with Methods========");
const objWithMethod = {
    a: 1,
    b: 2,
    greet() {
        return 'Hello';
    }
};
const shallowMethod = shallowCopy(objWithMethod);
const deepMethod = deepCopy(objWithMethod);
console.log('Shallow Method:', shallowMethod.greet()); // 'Hello'
console.log('Deep Method:', deepMethod.greet);         // undefined (methods not copied by JSON)



// Example 4: Object with Date
console.log("\n\n");
console.log("=========Example 4: Object with Date========");
const objWithDate = {
    date: new Date(),
    value: 42
};
const shallowDate = shallowCopy(objWithDate);
const deepDate = deepCopy(objWithDate);
objWithDate.date.setFullYear(2000);
console.log('Shallow Date:', shallowDate.date); // Reflects changed date
console.log('Deep Date:', deepDate.date);       // String representation, not Date object

console.log("\n\n");
console.log("============================================");
console.log("\n\n");
