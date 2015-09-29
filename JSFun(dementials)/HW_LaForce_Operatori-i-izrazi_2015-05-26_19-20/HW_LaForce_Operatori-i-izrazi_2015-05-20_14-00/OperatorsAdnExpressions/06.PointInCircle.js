//Problem 6. Point in Circle
//Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
//    Examples:
//x	    y	    inside
//0	    1	    true
//-5	0	    true
//-4	5	    false
//1.5	-3	    true
//-4	-3.5	false
//100	-30	    false
//0	    0	    true
//0.2	-0.8	true
//0.9	-4.93	false
//2	    2.655	true
//Моля, отбележете, че примерите са за кръг с център 0,0 и радиус 2! Така е написан и кода.
//При желание може да се тества и с радиус 5, както е зададено(само трябва да се подмени стойността на r).

var x = -5, y = 0, r = 5 ;

function isIn(x,y,r){
    return ((x - 0) * (x - 0) + (y - 0) * (y - 0)) <= r * r;
}

console.log(isIn(x,y,r));
