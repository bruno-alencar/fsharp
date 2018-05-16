module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int = 
    number |> List.sum (fun f -> upperBound % f = 0)