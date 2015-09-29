//### Problem 7. Is prime
//*	Write an expression that checks if given positive integer number n (n < 100) is prime.
//
//    _Examples:_
//
//|  n | Prime? |
//|:--:|:------:|
//| 1  | false  |
//| 2  | true   |
//| 3  | true   |
//| 4  | false  |
//| 9  | false  |
//| 37 | true   |
//| 97 | true   |
//| 51 | false  |
//| -3 | false  |
//| 0  | false  |

var n = 37;

function isPrime(n) {
    var count = 0;
    for (i=2; i < n; i++) {
        if (n % i == 0) {
            count++;
        }
    }
    return count == 0;
}

console.log(isPrime(n));