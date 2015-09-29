//### Problem 2. Multiplication Sign
//*	Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//*	Use a sequence of `if` operators.
//
//    _Examples:_
//
//| a    | b    | c    | result |
//|------|------|------|:------:|
//| 5    | 2    | 2    | +      |
//| -2   | -2   | 1    | +      |
//| -2   | 4    | 3    | -      |
//| 0    | -2.5 | 4    | 0      |
//| -1   | -0.5 | -5.1 | -      |

var a = -1, b = -0.5, c = -5.1;

console.log(sign(a,b,c));

function sign(a, b, c) {
    if (a == 0 || b == 0 || c == 0) {
        return 0;
    }
    else {
        var countMinus = 0;
        if (a < 0) {
            countMinus++;
        }
        if (b < 0) {
            countMinus++;
        }
        if (c < 0) {
            countMinus++;
        }
        return !(countMinus % 2) ? "+" : "-" ;
    }
}

