module CollatzConjecture

// let rec calculate (number: int): int option = 
//     let rec data = 
//     match number with
//         | _ when number <= 1 -> Some number
//         | _ when number % 2 = 0 -> calculate (number / 2)
//         | _ when number % 2 = 1 -> calculate (3 * number + 1)
    
// let rec loop acc calculate (x: int): int option=
//         if x <= 1 then
//             Some acc
//         else if  x % 2 = 0 then
//             calculate (x / 2) 
//         else 
//             calculate (3 * x + 1)

        // match x with
        //     | _ when x <= 1 -> Some total
        //     | _ when x % 2 = 0 -> calculate (x / 2)
        //     | _ when x % 2 = 1 -> calculate (3 * x + 1)

    let rec calculate (x: int): int option =
        let counted f =
              let count = ref 0
              (fun calc -> 
                if x <= 1 then
                    Some count
                else if  x % 2 = 0 then
                    count := count + 1
                    calc (x / 2)
                else 
                    calc (3 * x + 1))
        Some (counted x)

        
    let steps (number: int): int option = 
        // match number with
        //     | x when x < 0 -> None
        //     | x -> 
        calculate number
        

    // match number with
    // | _ -> calculate number
    // | _ when number <= 1 -> Some 0

    // | _ when number < 0 -> steps  (value / 2)
    // | None -> steps (3 * value + 1) 