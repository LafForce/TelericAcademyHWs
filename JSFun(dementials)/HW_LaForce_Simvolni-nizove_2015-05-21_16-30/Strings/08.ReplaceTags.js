//### Problem 8. Replace tags
//*	Write a JavaScript function that replaces in a HTML document given as string all the tags `<a href="�">�</a>` with corresponding tags `[URL=�]�/URL]`.
//_Example:_
//| input | output |
//|:-----:|:------:|
//| `<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>` | `<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>` |

var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
var text = getText(html);
console.log(text);

function getText(html){
    return html.replace(/<[^>]*>/g, '');
}