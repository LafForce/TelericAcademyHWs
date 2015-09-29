//### Problem 4. Sort 3 numbers
//*	Sort 3 real values in descending order.
//*	Use nested `if` statements.
//    _Note: Don’t use arrays and the built-in sorting functionality._
//_Examples:_
//| a    | b    | c    |     result     |
//|------|------|------|----------------|
//| 5    | 1    | 2    | 5 2 1          |
//| -2   | -2   | 1    | 1 -2 -2        |
//| -2   | 4    | 3    | 4 3 -2         |
//| 0    | -2.5 | 5    | 5 0 -2.5       |
//| -1.1 | -0.5 | -0.1 | -0.1 -0.5 -1.1 |
//| 10   | 20   | 30   | 30 20 10       |
//| 1    | 1    | 1    | 1 1 1          |

var arr = [3, 1, 2];

console.log(sortEm(arr));

function sortEm(arr) {

    var a = arr[0], b = arr[1], c = arr[2];

    var sorted = [];

    if (a >= b) {
        if (b >= c) {
            sorted.push(a, b, c);
        }
        else if (c > a) {
            sorted.push(c, a, b);
        }
        else {
            sorted.push(a, c, b);
        }
    }
    else {
        if (b >= c) {
            if (c >= a) {
                sorted.push(b, c, a);
            }
            else {
                sorted.push(b, a, c);
            }
        }
        else {
            sorted.push(c, b, a);
        }
    }

    return sorted;
}