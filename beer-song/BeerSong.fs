module BeerSong

let rec bottles number (list: string list)=
    match number with
        | 1 -> ["None bottles of beer on the wall, 99 bottles of beer.";
        "Take one down and pass it around, 98 bottles of beer on the wall."]
        | number when number > 0 -> 
               ["%i bottles of beer on the wall, %i bottles of beer." number (number-1);
                "Take one down and pass it around, %i bottles of beer on the wall." (number-1)]
     |> list.concat
     |> bottles (number-1)
    //  bottles list number-1
    

let recite (startBottles: int) (takeDown: int) = 
    [startBottles..startBottles-takeDown]
    |> List.add "%i bottles of beer on the wall, 99 bottles of beer.";
          "Take one down and pass it around, %i bottles of beer on the wall." startBottles (startBottles-1) 
