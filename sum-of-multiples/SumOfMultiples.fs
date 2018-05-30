module SumOfMultiples

let filter(numbers: int list) (value: int): int = 
            List.filter(fun f -> item % number = 0) numbers
            // for item in number do
            //     if item % value = 0 then item else 0

let sum (numbers: int list) (upperBound: int): int = 
    [0..upperBound]
    |> filter(numbers)
    // |> List.filter (fun f -> upperBound % f = 0 && f = upperBound)
    |> List.sum

// let divides (input: int) (modulus: int): bool = input % modulus = 0

// let isDivisibleByAny (numbers: int list) (input: int): bool = List.exists (divides input) numbers

// let sum (numbers: int list) (upperBound: int): int = 
//     [0..upperBound]
//     |> List.filter (isDivisibleByAny numbers) 
//     |> List.sum 