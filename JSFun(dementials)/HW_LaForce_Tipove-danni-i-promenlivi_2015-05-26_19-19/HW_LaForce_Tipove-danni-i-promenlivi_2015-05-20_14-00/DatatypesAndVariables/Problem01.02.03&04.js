//Data types and Variables
//========================
//
//### Problem 1. JavaScript literals
//*	Assign all the possible JavaScript literals to different variables.
//
//### Problem 2. Quoted text
//*	Create a string variable with quoted text in it.
//*	For example: `'How you doin'?', Joey said'.
//
//### Problem 3. Typeof variables
//*	Try typeof on all variables you created.
//
//### Problem 4. Typeof null
//*	Create null, undefined variables and try typeof on them.


//First thing's first:
var anObject = {name:"Neshto", size:"big", price:"0,0003"};
var arr = [1,2,3,4,5];
var aDate = new Date();
var num = 345; //JS numbers are all 32/64-bit floating point IEEE 754, no exceptions!
var numNull= null;//Task 3
var undefinedVar;//...this is an undefined var!
var isThisABool = true;
var aString = '"This is a "string" literal"'; //Second is second....
var func = function(){
    return 0;
}

//Third task goes here:
locals = [anObject, arr, aDate, num, numNull, undefinedVar, isThisABool, aString, func ];

for(var vAr in locals){
    console.log(getTypeString(locals[vAr]));
}

function getTypeString(vAr){
    var result = vAr;
    result += ' is ' + typeof vAr;
    return result;
}