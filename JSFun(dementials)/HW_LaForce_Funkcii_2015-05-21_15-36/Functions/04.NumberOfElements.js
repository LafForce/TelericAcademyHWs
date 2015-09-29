//### Problem 4. Number of elements
//*	Write a function to count the number of `div` elements on the web page

//заредете index.html в директорията, моля. Резултатите са в конзалата на броузара.
//А това е самата функция:

function countDivs() {
    var count = document.getElementsByTagName("div").length;
    console.log("The number of divs in your page is " + count);
}
