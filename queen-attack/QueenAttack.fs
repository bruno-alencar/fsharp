module QueenAttack

let create (x, y) = 
     (x > 0 && y > 0 ) && (x < 8 && y < 8)  
// let create (position:int * int) = 
    // match position with
    // | (a, b) -> (a > 0 && b > 0 ) && (a < 8 && b < 8)  

// let canAttack (queen1: int * int) (queen2: int * int) = 
let canAttack (x1, y1) (x2, y2) = 
    // let (x1, y1) = queen1
    // let (x2, y2) = queen2
    x1 = x2 || y1 = y2 || (abs (x1 - x2) = abs (y1 - y2))
    