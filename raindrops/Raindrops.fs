module Raindrops
open System.Globalization
open System.Runtime.ExceptionServices

let convert (number: int): string = 
    let factor = 
        [1..number]
        |> List.filter(fun e -> number % e = 0)
        |> List.map(fun e -> 
            match e with
                | 3 -> sprintf "Pling"
                | 2 -> sprintf "Plang"
                | 7 -> sprintf "Plong"
                | _ -> ""
        )

    match factor with
        | [] -> sprintf "%i" number
        | xs -> String.concat "" xs