module QueenAttack

let create (position: int * int) = 
    position >= (0,0) && position <= (8,8)

let canAttack (queen1: int * int) (queen2: int * int) = true