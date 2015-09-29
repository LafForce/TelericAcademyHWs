//Problem 2. HTML binding
//
//Write a function that puts the value of an object into the content/attributes of HTML tags.
//    Add the function to the String.prototype
//Example 1:
//
//input
//
//var str = '<div data-bind-content="name"></div>';
//str.bind(str, {name: 'Steven'});
//output
//
//<div data-bind-content="name">Steven</div>
//    Example 2:
//
//input
//
//var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></à>'
//str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'});
//output
//
//<a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class

String.prototype.bind = function(output, parameters) {
    var regCont,
        regHREF,
        regClass,
        prop;
    output = this;

    for (prop in parameters) {
        regCont = new RegExp('(<.*?data-bind-content="' + prop + '".*?>)(.*?)(<\\s*/.*?>)', 'g');
        regHREF = new RegExp('(<.*?data-bind-href="' + prop + '".*?)>', 'g');
        regexClass = new RegExp('(<.*?data-bind-class="(' + prop + ')".*?)>', 'g');

        output = output.replace(regCont, function(element, openingTag, content, closingTag) {
            return openingTag + parameters[prop] + closingTag;
        });

        output = output.replace(regHREF, function (tag, contentBeforeClosing) {
            return contentBeforeClosing + ' href="' + parameters[prop] + '">';
        });

        output = output.replace(regClass, function (tag, contentBeforeClosing) {
            return contentBeforeClosing + ' class="' + parameters[prop] + '">';
        });
    }

    return output;
};

console.log('<div data-bind-content="name"></div>'.bind('', {name: 'Steven'}));
console.log('<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></div>'.bind('', {name: 'Elena', link: 'http://telerikacademy.com'}));
