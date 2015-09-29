//### Problem 6. Extract text from HTML
//*	Write a function that extracts the content of a html page given as text.
//*	The function should return anything that is in a tag, without the tags.
//    _Example:_
//<html>
//<head>
//<title>Sample site</title>
//</head>
//<body>
//<div>text
//<div>more text</div>
//and more...
//</div>
//in body
//</body>
//</html>
//_Result:_ Sample sitetextmore textand more...in body


var paragraph = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. ' +
    'Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

paragraph = replaceLinkTags(paragraph);
console.log(paragraph);

function replaceLinkTags(text){
    var regex = /<\s*a\s+href\s*=\s*"(.*?)"\s*>(.*?)<\s*\/a\s*>/gi;

    return text.replace(regex, function(tag, url, content) {
        return '[URL=' + url + ']' + content + '[\/URL]';
    });
}
