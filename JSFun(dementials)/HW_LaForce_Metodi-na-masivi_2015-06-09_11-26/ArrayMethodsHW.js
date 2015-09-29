//Array Methods
//Problem 1. Make person
//Write a function for creating persons.
//    Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders

console.log("\nFirst task's solution: ");

var people = createPeople();
people.forEach(function(item) {
    console.log(item);
});

function createPerson(fname, lname, age, gender) {
    return {
        firstname: fname,
        lastname: lname,
        age: age,
        gender: gender
    };
}

function createPeople() {
    var i,
        firstNames = ['Alex', 'Ivan', 'Petkan', 'Pesho', 'Gosho', 'Anna', 'Eli', 'Gabriela ', 'Mariika'],
        lastNames = ['Ivanov', 'Dimitrov', 'Petrov', 'Gigova', 'Atanasova', 'Ivanova', 'Georgieva'],
        arr = [];
    for (i = 0; i < 10; i += 1) {
        arr[i] = createPerson(firstNames[i], lastNames[i], (Math.random() * 68) | 0, (i > 4));
    }
    return arr;
}


//Problem 2. People of age
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while)

console.log("\nSecond task's solution: ");

var ofAgeOnly =
    people.every(function(item) {
        return item.age >= 18;
    });
console.log(ofAgeOnly);


//    Problem 3. Underage people
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)


console.log("\nThird task's solution: ");

var underaged =
    people.filter(function(item) {
        return item.age < 18;
    }).forEach(function(item) {
        console.log(item);
    });
console.log('===========================');

//Problem 4. Average age of females
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)

console.log("\nFourth task's solution: ");

var femaleSum =
    people.filter(function(item) {
        return item.gender;
    }).reduce(function(sum, item, i, arr) {
        var count = arr.length;
        return (sum + item.age / count);
    }, 0);

console.log(femaleSum);

//Problem 5. Youngest person
//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//    Use Array#find

console.log("\nFifth task's solution: ");

if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

var youngestMale =
    people.sort(function(a, b) {
        return a.age - b.age;
    }).find(function(item) {
        return !item.gender;
    });

console.log(youngestMale.firstname, youngestMale.lastname);

//Problem 6. Group people
//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)
//    Example:
//
//        result = {
//            'a': [{
//                firstname: 'Asen',
//                /* ... */
//            }, {
//                firstname: 'Anakonda',
//                /* ... */
//            }],
//            'j': [{
//                firstname: 'John',
//                /* ... */
//            }]
//        };

console.log("\nSixth task's solution: ");

var result = people.reduce(function(obj, item) {
    if (obj[item.firstname]) {
        obj[item.firstname].push(item);
    } else {
        obj[item.firstname] = [item];
    }
    return obj;
}, {});

console.log(result);