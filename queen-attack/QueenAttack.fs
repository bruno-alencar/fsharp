module QueenAttack

let create (position: int * int) = 
    match position with
    | (a, b) -> (a > 0 && b > 0 ) && (a < 8 && b < 8)  

let canAttack (queen1: int * int) (queen2: int * int) = 
    let q1 = queen1 |> create
    let q2 = queen2 |> create
    q1 && q2