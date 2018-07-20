module BeerSong

let execute (startBottles: int) (takeDown: int): string = 
    match startBottles with
    | 0 -> "no more"
    | x -> string x

let recite (startBottles: int) (takeDown: int) = 
    [startBottles..startBottles-takeDown]
    |> List.append "%s bottles of beer on the wall, 1 bottles of beer." execute
          "Take one down and pass it around, %i bottles of beer on the wall." f (f-1)
  