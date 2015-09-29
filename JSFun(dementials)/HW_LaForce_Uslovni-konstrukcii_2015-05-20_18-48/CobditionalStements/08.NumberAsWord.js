//### Problem 8. Number as words
//*	Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
//    _Examples:_
//| numbers | number as words               |
//|---------|-------------------------------|-
//| 0       | Zero                          |
//| 9       | Nine                          |
//| 10      | Ten                           |
//| 12      | Twelve                        |
//| 19      | Nineteen                      |
//| 25      | Twenty five                   |
//| 98      | Ninety eight                  |
//| 98      | Ninety eight                  |
//| 273     | Two hundred and seventy three |
//| 400     | Four hundred                  |
//| 501     | Five hundred and one          |
//| 617     | Six hundred and seventeen     |
//| 711     | Seven hundred and eleven      |
//| 999     | Nine hundred and ninety nine  |

var number = 615;

console.log(getString(number));

function getString(number) {
    var text = '';
    var hundreds = Math.floor(number / 100) % 10;
    var tens = Math.floor(number / 10) % 10;
    var ones = number % 10;

    if (!hundreds && !tens && !ones) {
        return 'zero';
    }

    if (hundreds) {
        text += getDigit(hundreds) + ' hundred';
    }

    if (tens || ones) {
        if (text.length) {
            text += ' and ';
        }

        if (tens) {
            if (tens === 1) {
                return text + getTeens(tens * 10 + ones);
            }
            text += getTens(tens);
        }

        if (ones) {
            if (tens) {
                text += '-';
            }

            text += getDigit(ones);
        }
    }

    return text;
}

function getDigit(digit) {
    switch (digit) {
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
            return '';
    }
}

function getTens(digit) {
    switch (digit) {
        case 2:
            return 'twenty';
        case 3:
            return 'thirty';
        case 4:
            return 'forty';
        case 5:
            return 'fifty';
        case 6:
            return 'sixty';
        case 7:
            return 'seventy';
        case 8:
            return 'eighty';
        case 9:
            return 'ninety';
        default:
            return '';
    }
}

function getTeens(digit) {
    switch (digit) {
        case 10:
            return 'ten';
        case 11:
            return 'eleven';
        case 12:
            return 'twelve';
        case 13:
            return 'thirteen';
        case 14:
            return 'fourteen';
        case 15:
            return 'fifteen';
        case 16:
            return 'sixteen';
        case 17:
            return 'seventeen';
        case 18:
            return 'eighteen';
        case 19:
            return 'nineteen';
        default:
            return '';
    }
}