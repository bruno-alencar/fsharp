module Raindrops
open System.Globalization
open System.Runtime.ExceptionServices

let concatenate (number: int) (factor :string list) : string = 
    match factor with
        | [] -> number.ToString()
        | item -> String.concat "" item

let convert (number: int): string = 
    [1..number]
    |> List.filter(fun e -> number % e = 0)
    |> List.choose (fun f ->  
        match f with
            | 3 -> Some "Pling"
            | 5 -> Some "Plang"
            | 7 -> Some "Plong"
            | _ -> None)
    |> concatenate number 