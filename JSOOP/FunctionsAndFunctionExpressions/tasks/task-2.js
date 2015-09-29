/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function primeFinder() {
    return function (startInp, endInp) {
        var result = [],
            div,
            i,
            j,
            isPrime = true,
            start = parseInt(startInp),
            end = parseInt(endInp);

        if (arguments.length < 2) {
            throw new Error("An argument is missing!");
        } else if (isNaN(startInp) || isNaN(endInp)) {
            throw new Error("Wrong input!");
        }

        for (i = start; i <= end; i += 1) {
            div = Math.sqrt(i);
            isPrime = true;
            if (i < 2) {
                isPrime = false;
            }
            for (j = 2; j <= div; j += 1) {
                if (!(i % j)) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) {
                result.push(i);
            }
        }
        return result;
    }
}

module.exports = findPrimes;
