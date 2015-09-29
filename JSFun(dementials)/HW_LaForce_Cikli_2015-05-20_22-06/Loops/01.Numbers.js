//### Problem 1. Numbers
//*	Write a script that prints all the numbers from `1` to `N`.

var n = 100;

console.log(createArr(n));

function createArr(n) {
    var result = [];
    for (var i = 1; i <= n; i++) {
        result.push(i);
    }
    return result;
}