/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sumOfArr() {
    return function(input) {
        var len = input.length,
            result = 0,
            i = 0,
            nextNumber;

        if (!len) {
            return null;
        }

        for (i; i < len; i += 1) {
            nextNumber = parseInt(input[i]);

            if (isNaN(nextNumber) || nextNumber == undefined) {
                throw new Error("no array or NaN value");
            }

            result += nextNumber;
        }
        
        return result;
    }
}


module.exports = sum;