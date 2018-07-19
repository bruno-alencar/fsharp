module BeerSong

let bottles x:int = "%i bottles of beer on the wall, 99 bottles of beer." x;


let recite (startBottles: int) (takeDown: int) = 
    [startBottles..startBottles-takeDown]
    |> "%i bottles of beer on the wall, 99 bottles of beer.";
          "Take one down and pass it around, %i bottles of beer on the wall." startBottles (startBottles-1)