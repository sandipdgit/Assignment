/*********************************************************************************** */
/*
Write a program in JavaScript which explains the use of the methods below on arrays -
•	push
•	pop
•	shift
•	unshift
•	splice
•	slice
•	concat
•	indexOf
•	lastIndexOf
•	includes
•	find
•	filter
•	findIndex
•	forEach
•	map
•	sort
•	reverse
•	split
•	reduce
*/
/*********************************************************************************** */



console.log('Array Method Example js file');
//export function fnProgram1()
function fnProgram1() {

// JavaScript Program to Demonstrate Various Array Methods

const arr = [1, 2, 3, 4, 5];

// 1. push - Adds elements to the end
arr.push(6);
console.log('push:', arr , '\n');

// 2. pop - Removes the last element
arr.pop();
console.log('pop:', arr, '\n');

// 3. shift - Removes the first element
arr.shift();
console.log('shift:', arr, '\n');

// 4. unshift - Adds elements to the start
arr.unshift(0);
console.log('unshift:', arr, '\n');

// 5. splice - Adds/Removes elements
arr.splice(2, 1, 'a', 'b'); // Removes 1 element at index 2 and adds 'a', 'b'
console.log('splice:', arr, '\n');

// 6. slice - Returns a portion of the array
console.log('slice:', arr.slice(1, 4), '\n');

// 7. concat - Merges arrays
console.log('concat:', arr.concat([7, 8, 9]), '\n');

// 8. indexOf - Finds index of first occurrence
console.log('indexOf:', arr.indexOf('a'), '\n');

// 9. lastIndexOf - Finds index of last occurrence
arr.push('a');
console.log('lastIndexOf:', arr.lastIndexOf('a'), '\n');

// 10. includes - Checks if element exists
console.log('includes 3:', arr.includes(3), '\n');

// 11. find - Returns the first element that satisfies the condition
console.log('find:', arr.find(el => typeof el === 'number' && el > 3), '\n');

// 12. filter - Returns elements that satisfy the condition
console.log('filter:', arr.filter(el => typeof el === 'number'), '\n');

// 13. findIndex - Returns the index of the first element that satisfies the condition
console.log('findIndex:', arr.findIndex(el => typeof el === 'string'), '\n');

// 14. forEach - Iterates over each element
console.log('forEach:');
arr.forEach(el => console.log(el));
console.log('\n')

// 15. map - Creates a new array with the results of calling a function on every element
 console.log('map:', arr.map(el => (typeof el === 'number' ? el * 2 : el)), '\n');

// 16. sort - Sorts the array
console.log('sort:', arr.sort(), '\n');

// 17. reverse - Reverses the array
console.log('reverse:', arr.reverse(), '\n');

// 18. split - Splits a string into an array
const str = 'Hello,World';
console.log('split:', str.split(','), '\n');

// 19. reduce - Reduces the array to a single value
console.log('reduce:', arr.reduce((acc, cur) => acc + (typeof cur === 'number' ? cur : 0), 0), '\n');

}

fnProgram1();
