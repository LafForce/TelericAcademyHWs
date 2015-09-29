//### Problem 2. Numbers not divisible
//*	Write a script that prints all the numbers from `1` to `N`, that are not divisible by `3` and `7` at the same time

var n = 22; //the first such number is 21!

console.log(createArr(n));

function createArr(n) {
    var result = [];
    for (var i = 1; i <= n; i++) {
        if (i % (3 * 7)) {
            result.push(i);
        }
    }
    return result;
}