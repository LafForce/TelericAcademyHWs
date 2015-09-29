//### Problem 3. The biggest of Three
//*	Write a script that finds the biggest of three numbers.
//*	Use nested `if` statements.
//
//    _Examples:_
//
//| a    | b    | c    | biggest |
//|------|------|------|:-------:|
//| 5    | 2    | 2    | 5       |
//| -2   | -2   | 1    | 1       |
//| -2   | 4    | 3    | 4       |
//| 0    | -2.5 | 5    | 5       |
//| -0.1 | -0.5 | -1.1 | -0.1    |

var a = 5, b = 2, c = 2;

console.log(bigerOfThree(a, b, c));

function bigerOfThree(a, b, c) {
    if (a > b) {
        if (a > c) {
            return a;
        }
        return c;
    }
    if (c > b) {
        return c;
    }

    return b;
}