module CollatzConjecture

let steps (number: int): int option = 
    match number % 2 = 0 with
    | Some -> steps  (number / 2)
    | None -> steps (3 * number + 1)