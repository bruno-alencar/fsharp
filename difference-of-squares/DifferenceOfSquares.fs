module DifferenceOfSquares

let square x = x * x
let squareOfSum (number: int): int = 
    [|1..number|]
    |> Array.sum
    |> square

let sumOfSquares (number: int): int = 0

let differenceOfSquares (number: int): int = 0