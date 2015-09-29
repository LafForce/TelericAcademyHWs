//### Problem 1. Exchange if greater
//*	Write an `if` statement that takes two double variables `a` and `b` and exchanges their values if the first one is
// greater than the second.
//*	As a result print the values `a` and `b`, separated by a space.
//
//    _Examples:_
//
//| a    | b   | result  |
//|------|-----|---------|
//| 5    | 2   | 2 5     |
//| 3    | 4   | 3 4     |
//| 5.5  | 4.5 | 4.5 5.5 |

var a = 5.5, b = 4.5;

function exIfGr(a, b) {
    if (a > b) {
        var c = a;
        a = b;
        b = c;
    }
return a + ' ' + b;
}

console.log(exIfGr(a,b));
