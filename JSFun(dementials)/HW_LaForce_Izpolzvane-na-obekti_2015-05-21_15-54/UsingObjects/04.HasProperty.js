//### Problem 4. Has property
//*	Write a function that checks if a given object contains a given property.
//    var obj  = …;
//var hasProp = hasProperty(obj, 'length');

var obj = {
    name: 'John Smith',
    age: 18 ,
    occupation: 'Ordinary guy'
};

console.log(hasProperty(obj, 'occupation'));
console.log(hasProperty(obj, 'gender'));
obj.gender = 'unknown';
console.log(hasProperty(obj, 'gender'));

function hasProperty(obj, prop){
    return obj.hasOwnProperty(prop);
}
