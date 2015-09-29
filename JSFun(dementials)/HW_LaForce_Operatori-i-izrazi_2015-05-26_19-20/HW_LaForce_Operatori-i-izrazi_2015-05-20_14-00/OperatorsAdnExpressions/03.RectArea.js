//### Problem 3. Rectangle area
//*	Write an expression that calculates rectangle’s area by given width and height.
//
//    _Examples:_
//
//| width | height | area |
//|:-----:|:------:|:----:|
//| 3     | 4      | 12   |
//| 2.5   | 3      | 7.5  |
//| 5     | 5      | 25   |

var width = 2.5;
var height = 3;

function area(sideA, sideB) {
    return sideA * sideB;
}

console.log(area(width,height));