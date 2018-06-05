module SumOfMultiples

// let change (numbers: int list) (value: int): int = 
//             numbers
//             |> List.filter(fun f -> f % value = 0)
            // for item in number do
            //     if item % value = 0 then item else 0

let sum (numbers: int list) (upperBound: int): int = 
    [0..upperBound]
    // |> change (numbers)
    |> List.sum
    // |> List.filter (fun f -> upperBound % f = 0 && f = upperBound)

// let divides (input: int) (modulus: int): bool = input % modulus = 0

// let isDivisibleByAny (numbers: int list) (input: int): bool = List.exists (divides input) numbers
// let sum (numbers: int list) (upperBound: int): int = 
//     [0..upperBound]
//     |> List.filter (isDivisibleByAny numbers) 
//     |> List.sum 