module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int = 
    List.sum (fun f -> upperBound % f = 0 )

//     module SumOfMultiples

// let divides (input: int) (modulus: int): bool = input % modulus = 0

// let isDivisibleByAny (numbers: int list) (input: int): bool = List.exists (divides input) numbers

// let sum (numbers: int list) (upperBound: int): int = 
//     [1..upperBound-1]
//     |> List.filter (isDivisibleByAny numbers) 
//     |> List.sum 