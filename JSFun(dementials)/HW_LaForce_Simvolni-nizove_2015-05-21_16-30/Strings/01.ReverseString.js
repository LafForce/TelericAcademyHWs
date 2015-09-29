//### Problem 1. Reverse string
//*	Write a JavaScript function that reverses a string and returns it.
//    _Example:_
//|  input | output |
//|:------:|:------:|
//| sample | elpmas |

console.log(reverse('sample'));
console.log(reverse('reverse'));

function reverse(string){
    var reversed = [];

    for(var ind = string.length - 1; ind >= 0; ind--){
        reversed.push(string[ind]);
    }

    return reversed.join('');
}