//### Problem 1. Odd or Even
//*	Write an expression that checks if given integer is odd or even.
//
//    _Examples:_
//
//|  n |  Odd? |
//|:--:|:-----:|
//| 3  | true  |
//| 2  | false |
//| -2 | false |
//| -1 | true  |
//| 0  | false |

var even = -2, odd = 3;

console.log(isOdd(even));
console.log(isOdd(odd));

function isOdd(number){
    return !(number % 2) == 0;
}
