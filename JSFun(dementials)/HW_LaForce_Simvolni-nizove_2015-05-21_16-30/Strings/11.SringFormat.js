//### Problem 11. String format
//*	Write a function that formats a string using placeholders.
//*	The function should work with up to 30 placeholders and all types.
//    _Examples:_
//var str = stringFormat('Hello {0}!', 'Peter');
////str = 'Hello Peter!';
//var frmt = '{0}, {1}, {0} text {2}';
//var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
////str = '1, Pesho, 1 text Gosho'

console.log(format('{0}, {1}, {0} text {2}',  1, 'Pesho', 'Gosho'));

function format(){
    var args = arguments;
    var string = args[0];

    for(var ind = 1; ind < args.length; ind++){
        var placeholder ='{' + (ind - 1) + '}';
        while(string.indexOf(placeholder) > -1) {
            string = string.replace(placeholder, args[ind]);
        }
    }

    return string;
}