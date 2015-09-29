//### Problem 6. Quadratic equation
//*	Write a script that reads the coefficients `a`, `b` and `c` of a quadratic equation ax<sup>2</sup> + bx + c = 0
// and solves it (prints its real roots).
//*	Calculates and prints its real roots.
//    _Note: Quadratic equations may have 0, 1 or 2 real roots._
//_Examples:_
//|   a  |  b  |  c  |     roots     |
//|:----:|:---:|:---:|---------------|
//| 2    | 5   | -3  | x1=-3; x2=0.5 |
//| -1   | 3   | 0   | x1=3; x2=0    |
//| -0.5 | 4   | -8  | x1=x2=4       |
//| 5    | 2   | 8   | no real roots |

var a = 2, b= 5, c =-3;

console.log(getRoots(a,b,c));

function getRoots(a, b, c){
    var D = b * b - 4 * a * c;
    if(D < 0){
        return [null];
    }
    else if(!D){
        return [getRoot(-1, D, b, a)];
    }
    else{
        return[getRoot(1, D, b, a), getRoot(-1, D, b, a)];
    }
}

function getRoot(sign, D, b, a){
    return (-b + Math.sqrt(D) * sign) / (2 * a);
}
