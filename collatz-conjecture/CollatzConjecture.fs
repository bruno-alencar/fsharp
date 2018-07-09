module CollatzConjecture

let rec calculate (number: int): int option = 
    match number with
    | _ when number <= 1 -> Some number
    | _ when number % 2 = 0 -> calculate (number / 2)
    | _ when number % 2 = 1 -> calculate (3 * number + 1)

let steps (number: int): int option = 
    match number with
    | _ when number <= 1 -> Some 0
    | _ -> calculate number

    // | _ when number < 0 -> steps  (value / 2)
    // | None -> steps (3 * value + 1) 