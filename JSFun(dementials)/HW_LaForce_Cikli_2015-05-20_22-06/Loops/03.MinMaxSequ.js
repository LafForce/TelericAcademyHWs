//### Problem 3. Min/Max of sequence
//*	Write a script that finds the `max` and `min` number from a sequence of numbers.

var sequ = [23, 45, 3, 2, 1, 2, 3, 4543, -23, 0.4];

console.log(minFind(sequ));
console.log(maxFind(sequ));

function minFind(sequ) {
    var min = sequ[0];
    for (var i = 0; i<sequ.length; i++) {
        if (min > sequ[i]) {
            min = sequ[i];
        }
    }
    return min;
}

function maxFind(sequ) {
    var max = sequ[0];
    for (var i = 0; i<sequ.length; i++)  {
        if (max < sequ[i]) {
            max = sequ[i];
        }
    }
    return max;
}

