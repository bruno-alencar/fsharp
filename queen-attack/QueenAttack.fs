module QueenAttack

let create (position: int * int) = 
    match position with
    | (a, b) -> (a > 0 && b > 0 ) && (a < 8 && b < 8)  

let canAttack (queen1: int * int) (queen2: int * int) = false