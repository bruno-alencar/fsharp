module KindergartenGarden

// TODO: define the Plant type
type Plant = 
    | Grass = 'G'
    | Clover = 'C'
    | Violets = 'V'
    | Radishes = 'R'

let plants diagram student = 
    match diagram with 
    |  a as Plant  -> a
    | _ -> "test"

