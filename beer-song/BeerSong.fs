module BeerSong
open System.Globalization

let bottles (number: int)=
    match number with
        | 0 -> "No more bottles of beer on the wall, no more bottles of beer.";"\n Go to the store and buy some more, 99 bottles of beer on the wall."
        | 1 -> sprintf "%i bottle of beer on the wall, %i bottle of beer. \n Take it down and pass it around, no more bottles of beer on the wall." number number
        | 2 -> sprintf "%i bottles of beer on the wall, %i bottles of beer. \n Take one down and pass it around, %i bottle of beer on the wall." number number (number-1)
        | _ -> sprintf "%i bottles of beer on the wall, %i bottles of beer. \n Take one down and pass it around, %i bottles of beer on the wall." number number (number-1)
        
        //  | _ -> sprintf "%i bottles of beer on the wall, %i bottles of beer.\nTake one down and pass it around, %i bottles of beer on the wall.\n"
        //     number
        //     number
        //     (number - 1)

let recite (startBottles: int) (takeDown: int) =
    [startBottles.. -1 ..takeDown]
    |> List.map bottles

    // List.map bottles list
    // |> List.append list
        
    
