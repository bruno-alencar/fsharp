module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int = 
     List.sum (fun f -> upperBound % f = 0)