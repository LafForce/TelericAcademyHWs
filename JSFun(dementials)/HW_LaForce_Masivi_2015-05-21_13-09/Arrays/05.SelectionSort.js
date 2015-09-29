//### Problem 5. Selection sort
//*	Sorting an array means to arrange its elements in increasing order.
//*	Write a script to sort an array.
//*	Use the [selection sort](http://en.wikipedia.org/wiki/Selection_sort) algorithm: Find the smallest element, move it
// at the first position, find the smallest from the rest, move it at the second position, etc.
//_Hint: Use a second array_

Array.prototype.selectionSort = function(){
    var sorted = [];

    while(this.length) {
        var minInd = 0;
        for (var ind = 0; ind < this.length; ind++) {
            if(this[ind] < this[minInd]) minInd = ind;
        }
        sorted.push(this[minInd]);
        this.splice(minInd, 1);
    }
    this.push(sorted);
}

var numbers =  [8, 12, 3, 4,1276,123,1245,-123, 5, 2, 11, 13, 7, 4, 15, 14, 12, 8, 1];
numbers.selectionSort();

console.log(numbers.join(', '));
