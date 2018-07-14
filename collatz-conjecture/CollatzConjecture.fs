module CollatzConjecture

    // let rec calculate (x: int): int option =
    //     let counted f =
    //           let count = ref 0
    //           (fun calc -> 
    //             if x <= 1 then
    //                 Some count
    //             else if  x % 2 = 0 then
    //                 count := count + 1
    //                 calc (x / 2)
    //             else 
    //                 calc (3 * x + 1))
    //     Some (counted x)

    let nextNumber number = 
        if number % 2 = 0 then
           number / 2
        else 
            number * 3 + 1

    let steps (number: int): int option = 
        let rec calculate acc n =
            match n with
            | n when n <= 0 -> None
            | n when n = 1 -> Some acc
            | n -> 
                if n % 2 = 0 then
                   n / 2
                else 
                    n * 3 + 1  
                |> calculate (acc + 1)
        calculate 0 number
             