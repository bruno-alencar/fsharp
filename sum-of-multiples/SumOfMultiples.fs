module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int = 
    numbers | List.sum (fun f -> upperBound % f = 0)