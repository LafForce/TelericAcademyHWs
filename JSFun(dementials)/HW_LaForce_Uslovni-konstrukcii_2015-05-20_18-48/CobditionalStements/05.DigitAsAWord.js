//### Problem 5. Digit as word
//*	Write a script that asks for a digit `(0-9)`, and depending on the input, shows the digit as a word (in English).
//*	Print `�not a digit�` in case of invalid input.
//*	Use a `switch` statement.
//    _Examples:_
//| digit | result      |
//|-------|-------------|
//| 2     | two         |
//| 1     | one         |
//| 0     | zero        |
//| 5     | five        |
//| -0.1  | not a digit |
//| hi    | not a digit |
//| 9     | nine        |
//| 10    | not a digit |

console.log(digitAsAWord(7));

function digitAsAWord(digit){

    switch(digit){
        case 0:
            return 'zero';
        case 1:
            return 'one';
        case 2:
            return 'two';
        case 3:
            return 'three';
        case 4:
            return 'four';
        case 5:
            return 'five';
        case 6:
            return 'six';
        case 7:
            return 'seven';
        case 8:
            return 'eight';
        case 9:
            return 'nine';
        default:
            return ' not a digit';
    }
}