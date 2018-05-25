module SumOfMultiples

// let sum (numbers: int list) (upperBound: int): int = 
//     [0..upperBound]
//     |> List.filter (fun f -> upperBound % f = 0 && f = upperBound)
//     |> List.sum

let divides (input: int) (modulus: int): bool = input % modulus = 0

let isDivisibleByAny (numbers: int list) (input: int): bool = List.exists (divides input) numbers

let sum (numbers: int list) (upperBound: int): int = 
    [0..upperBound]
    |> List.filter (isDivisibleByAny numbers) 
    |> List.sum 