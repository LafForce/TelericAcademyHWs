//### Problem 2. Remove elements
//*	Write a function that removes all elements with a given value.
//*	Attach it to the array type.
//*	Read about **prototype** and how to attach methods.
//
//    var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
//arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];


Array.prototype.remove = function(element){
    for(var ind = 0; ind < this.length; ind++){
        if(this[ind] === element){
            this.splice(ind, 1);
            --ind;
        }
    }
    return this;
}

var arr =  [1,2,1,4,1,3,4,1,111,3,2,1,'1'];

console.log(arr.join(', '));
arr.remove(1);
console.log(arr.join(', '));