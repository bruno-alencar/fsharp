module CollatzConjecture

    let rec calculate count number =
            match number with
            | number when number <= 0 -> None
            | number when number = 1 -> Some count
            | number -> 
                match number % 2 = 0 with
                    | true -> number / 2
                    | false -> number * 3 + 1  
                |> calculate (count + 1)

    let steps (number: int): int option = 
        calculate 0 number
             