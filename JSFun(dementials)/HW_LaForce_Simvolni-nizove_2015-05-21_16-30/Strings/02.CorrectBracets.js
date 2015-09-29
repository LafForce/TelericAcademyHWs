//### Problem 2. Correct brackets
//*	Write a JavaScript function to check if in a given expression the brackets are put correctly.
//    _Example of correct expression:_ `((a+b)/5-d)`.
//_Example of incorrect expression:_ `)(a+b))`.


console.log(isCorrectExpression('((a+b)/5-d)'));
console.log(isCorrectExpression(')(a+b))'));

function isCorrectExpression(expr){
    var check = 0;

    for(var ind = 0; ind < expr.length; ind++){
        if(expr[ind] === '('){
            check++;
        }
        else if(expr[ind] === ')'){
            check--;
        }

        if(check < 0) return false;
    }

    return !check;

