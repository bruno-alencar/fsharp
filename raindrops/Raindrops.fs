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
                | 5 -> sprintf "Plang"
                | 7 -> sprintf "Plong"
                | _ -> null
        )  
        |> List.filter(fun g -> g <> null)
    
    match factor with
        | [] -> number.ToString()
        | xs -> String.concat "" xs