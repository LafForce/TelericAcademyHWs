//### Problem 2. Divisible by 7 and 5
//*	Write a boolean expression that checks for given integer if it can be divided (without remainder) by `7` and `5`
// in the same time.
//
//    _Examples:_
//
//|  n  | Divided by 7 and 5? |
//|:---:|:-------------------:|
//| 3   | false               |
//| 0   | true                |
//| 5   | false               |
//| 7   | false               |
//| 35  | true                |
//| 140 | true                |

var amIDivisible = 140;

function divisBy7And5(number) {
    return !(number % 5) && !(number % 7);
}
console.log(divisBy7And5(amIDivisible));