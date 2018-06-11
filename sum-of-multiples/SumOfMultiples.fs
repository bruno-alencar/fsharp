module SumOfMultiples

    let change (value: int) (numbers: int list) : int list  = 
             List.filter(fun f -> value % f = 0) numbers
         

    let sum (numbers: int list) (upperBound: int): int = 
        [1..upperBound-1]
        |> List.filter(fun e ->
                    numbers 
                    |> List.exists(fun f -> e % f = 0))
        |> List.sum
