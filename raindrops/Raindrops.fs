module Raindrops
open System.Globalization

let isDivisible (number: int) (value: int): bool = 
        number % value = 0 

let convert (number: int): string = 
    [1..number]
    |> List.filter(fun e -> 
                number % e = 0 
                |> match e with
                    | 3 -> "Pling"
                    | 2 -> "Plang"
                    | 7 -> "Plong"
                    | _ -> sprintf "%i" e
    )
    |> List.concat(fun e -> yield e)