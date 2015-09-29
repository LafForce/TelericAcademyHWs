//### Problem 9. Point in Circle and outside Rectangle
//*	Write an expression that checks for given point `P(x, y)` if it is within the circle `K( (1,1), 3)` and out of the
// rectangle `R(top=1, left=-1, width=6, height=2)`.
//_Examples:_
//|   x  |   y  | inside K & outside of R |
//|:----:|:----:|:-----------------------:|
//| 1    | 2    | yes                     |
//| 2.5  | 2    | no                      |
//| 0    | 1    | no                      |
//| 2.5  | 1    | no                      |
//| 2    | 0    | no                      |
//| 4    | 0    | no                      |
//| 2.5  | 1.5  | no                      |
//| 2    | 1.5  | yes                     |
//| 1    | 2.5  | yes                     |
//| -100 | -100 | no                      |

var xCoord = 1, yCoord = 2;

var isInsideCircle = Math.pow((xCoord - 1), 2) + Math.pow((yCoord - 1), 2) <= Math.pow((3), 2);

var isOutsideRectangle = (((xCoord < -2) || (xCoord > 5)) || ((yCoord < -1) || (yCoord > 1)));

console.log((isInsideCircle && isOutsideRectangle) ? "yes" : "no");