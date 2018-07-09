module CollatzConjecture

let steps (number: int): int option = 
    match number with
    | _ when number % 2 = 0 -> Some number
    | _ -> Some 0

    // | _ when number < 0 -> steps  (value / 2)
    // | None -> steps (3 * value + 1) 