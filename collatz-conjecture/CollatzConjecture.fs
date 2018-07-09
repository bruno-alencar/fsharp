module CollatzConjecture

let steps (number: int): int option = 
    match number % 2 = 0 with
    | Some value -> steps  (value / 2)
    | None -> steps (3 * value + 1)