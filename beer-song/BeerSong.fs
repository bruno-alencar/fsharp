module BeerSong
open System.Globalization

let rec bottles (number: int): string list =
    match number with
        | 0 -> ["No more bottles of beer on the wall, 99 bottles of beer.";
                "Go to the store and buy some more, 99 bottles of beer on the wall."]
        | 1 -> [sprintf "%i bottles of beer on the wall, %i bottles of beer." number number;"Take it down and pass it around, no more bottles of beer on the wall."]
        | _ -> [sprintf "%i bottles of beer on the wall, %i bottles of beer." number number; sprintf "Take one down and pass it around, %i bottles of beer on the wall." (number-1)]

let recite (startBottles: int) (takeDown: int) = 
    // [startBottles..takeDown]
    // List.map 
    bottles startBottles
    
    
