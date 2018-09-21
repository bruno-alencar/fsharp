module KindergartenGarden

// TODO: define the Plant type
type Plant = 
| Grass = 'G'
| Clover = 'C'
| Violets = 'V'
| Radishes = 'R'
let students = [
    "Alice"; "Bob"; "Charlie"; "David"; "Eve"; "Fred"; 
    "Ginny"; "Harriet"; "Ileana"; "Joseph"; "Kincaid"; "Larry"
]

let plants diagram student = 
    match plants with
    | 'C' -> Clover
    | 'R' -> Radishes
    | 'G' -> Grass
    | 'V' -> Violets
