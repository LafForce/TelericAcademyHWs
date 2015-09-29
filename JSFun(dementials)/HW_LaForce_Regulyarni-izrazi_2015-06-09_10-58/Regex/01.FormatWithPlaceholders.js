//Problem 1. Format with placeholders
//
//    Write a function that formats a string. The function should have placeholders, as shown in the example
//Add the function to the String.prototype
//Example:
//
//    input	                                                      ||      output
//var options = {name: 'John'};                                   ||
//'Hello, there! Are you #{name}?'.format(options);               ||     	'Hello, there! Are you John'
//================================================================||===================================================
//var options = {name: 'John', age: 13};                          ||
//'My name is #{name} and I am #{age}-years-old').format(options);||	     'My name is John and I am 13-years-old'


String.prototype.format = function(options) {
    var option,
        regex,
        formatted = this;
    for (option in options) {
        regex = new RegExp('#{' + option + '}', 'g');
        formatted = formatted.replace(regex, options[option]);
    }

    return formatted;
};

var options = {name: 'John'};
var options2 = {name: 'John', age: 13};
console.log('First examples results: ');

console.log('Hello, there! Are you #{name}? \n'.format(options));
console.log('Second examples results: ');
console.log('My name is #{name} and I am #{age}-years-old'.format(options2));