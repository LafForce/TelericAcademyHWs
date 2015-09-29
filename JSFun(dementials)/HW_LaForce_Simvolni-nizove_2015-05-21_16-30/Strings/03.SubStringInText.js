//### Problem 3. Sub-string in text
//*	Write a JavaScript function that finds how many times a substring is contained in a given text (perform case
// insensitive search).
//_Example:_
//The target sub-string is `in`
//The text is as follows:
//We are liv**in**g **in** an yellow submar**in**e. We don't have anyth**in**g else. **in**side the submar**in**e is
// very tight. So we are dr**in**k**in**g all the day. We will move out of it **in** 5 days.
//The result is: `9`

var text = "We are liv**in**g **in** an yellow submar**in**e. We don't have anyth**in**g else. **in**side the " +
    "submar**in**e is very tight. So we are dr**in**k**in**g all the day. We will move out of it **in** 5 days.";

console.log(getOccurrenceCount(text, 'in'));

function getOccurrenceCount(text, word){
    var regex = new RegExp(word, 'gi');
    return (text.match(regex)).length;
}