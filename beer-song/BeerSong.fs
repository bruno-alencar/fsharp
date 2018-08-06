module BeerSong
open System.Globalization

// let verse n = 
//     match n with
//     | 0 -> "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.\n"
//     | 1 -> "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n"
//     | 2 -> "2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n"
//     | _ -> sprintf "%d bottles of beer on the wall, %d bottles of beer.\nTake one down and pass it around, %d bottles of beer on the wall.\n" n n (n-1)

// // let verses stop start = 
// let recite (startBottles: int) (takeDown: int) =
//     [takeDown .. -1 .. startBottles] 
//     |> List.map (fun i -> verse i + "\n") 
//     |> String.concat ""

let bottles (number: int)=
    match number with
        | 0 -> ["No more bottles of beer on the wall, no more bottles of beer.";"Go to the store and buy some more, 99 bottles of beer on the wall."]
        | 1 -> [sprintf "%i bottle of beer on the wall, %i bottle of beer."number number;"Take it down and pass it around, no more bottles of beer on the wall."]
        | 2 -> [sprintf "%i bottles of beer on the wall, %i bottles of beer." number number; sprintf "Take one down and pass it around, %i bottle of beer on the wall." (number-1);]
        | _ -> [sprintf "%i bottles of beer on the wall, %i bottles of beer."number number; sprintf "Take one down and pass it around, %i bottles of beer on the wall." (number-1);]
        // | 0 -> ["No more bottles of beer on the wall, no more bottles of beer.";
        //         "Go to the store and buy some more, 99 bottles of beer on the wall."]
        // | 1 -> [sprintf "%i bottle of beer on the wall, %i bottle of beer."number number; 
        //         "Take it down and pass it around, no more bottles of beer on the wall."]
        // | 2 -> [(sprintf "%i bottles of beer on the wall, %i bottles of beer." number number); 
        //         (sprintf "Take one down and pass it around, %i bottle of beer on the wall." (number-1))]
        // | _ -> [(sprintf "%i bottles of beer on the wall, %i bottles of beer."number number);
        //         (sprintf "Take one down and pass it around, %i bottles of beer on the wall." (number-1))] 

let recite (startBottles: int) (takeDown: int) =
        // List.collect bottles  ;[""];
        List.collect bottles [startBottles.. -1 ..startBottles-takeDown+1]
        |> List.concat [""]
        // |> List.concat [bottles;[""];recite (startBottles - 1) (takeDown - 1)]
//     List.collect bottles [startBottles.. -1 ..startBottles-takeDown+1]
        // String.concat "" [for i in startBottles .. -1 .. startBottles-takeDown+1 -> bottles i |> Array.append ["\n"]]
        // let list = []
        // [startBottles.. -1 ..startBottles-takeDown+1]
        // |> List.map bottles

        // |> List.fold(fun f -> List.append ["\n"])
        // |> List.concat

