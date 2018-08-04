module BeerSong
open System.Globalization

let bottles (number: int)=
    match number with
        | 0 -> ["No more bottles of beer on the wall, no more bottles of beer.";"Go to the store and buy some more, 99 bottles of beer on the wall."]
        | 1 -> [sprintf "%i bottle of beer on the wall, %i bottle of beer."number number;"Take it down and pass it around, no more bottles of beer on the wall."]
        | 2 -> [sprintf "%i bottles of beer on the wall, %i bottles of beer." number number; sprintf "Take one down and pass it around, %i bottle of beer on the wall." (number-1);]
        | _ -> [sprintf "%i bottles of beer on the wall, %i bottles of beer."number number; sprintf "Take one down and pass it around, %i bottles of beer on the wall." (number-1);]

let recite (startBottles: int) (takeDown: int) =
    List.collect bottles [startBottles.. -1 ..startBottles-takeDown+1]
    // |> List.concat "\n"
