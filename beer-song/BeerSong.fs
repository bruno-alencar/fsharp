
module BeerSong

// let bottles (number: int) =
let bottles (number: int) =
    match number with
        | 0 -> ["No more bottles of beer on the wall, no more bottles of beer.";"Go to the store and buy some more, 99 bottles of beer on the wall."]
        | 1 -> [sprintf "%i bottle of beer on the wall, %i bottle of beer."number number;"Take it down and pass it around, no more bottles of beer on the wall."]
        | 2 -> [sprintf "%i bottles of beer on the wall, %i bottles of beer." number number; sprintf "Take one down and pass it around, %i bottle of beer on the wall." (number-1);]
        | _ -> [sprintf "%i bottles of beer on the wall, %i bottles of beer."number number; sprintf "Take one down and pass it around, %i bottles of beer on the wall." (number-1);]

let rec recite (startBottles: int) (takeDown: int) = 
    let bottleLabel line = 
        match line with
        | 0 -> "No more bottles"
        | 1 -> "1 bottle"
        | _ -> sprintf "%d bottles" line
    let currentLabel = bottleLabel startBottles
    let nextLabel = bottleLabel (startBottles - 1)
    let lines = [
        sprintf "%s of beer on the wall, %s of beer." currentLabel (currentLabel.ToLower());
        (match startBottles with
        | 0 -> "Go to the store and buy some more, 99 bottles of beer on the wall."
        | _ -> sprintf "Take %s down and pass it around, %s of beer on the wall." (if startBottles = 1 then "it" else "one") (nextLabel.ToLower()))
    ]
    [startBottles.. -1 ..startBottles-takeDown+1]
    |> List.map (fun f -> 
                    let value = bottles

                    match f with
                    | _ when f <= 1 -> value
                    | _ -> List.append [bottles;[""]]
                )
    
