//### Problem 4. Number of elements
//*	Write a function to count the number of `div` elements on the web page

//�������� index.html � ������������, ����. ����������� �� � ��������� �� ��������.
//� ���� � ������ �������:

function countDivs() {
    var count = document.getElementsByTagName("div").length;
    console.log("The number of divs in your page is " + count);
}
