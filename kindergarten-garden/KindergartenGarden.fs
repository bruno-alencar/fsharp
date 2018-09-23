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

// let plants diagram student = 
//     // match plants with
//     // | 'C' -> Clover
//     // | 'R' -> Radishes
//     // | 'G' -> Grass
//     // | 'V' -> Violets
//     "Alice"; "Bob"; "Charlie"; "David"; "Eve"; "Fred"; 
//     "Ginny"; "Harriet"; "Ileana"; "Joseph"; "Kincaid"; "Larry"
// ]

let charToPlant = LanguagePrimitives.EnumOfValue
let rowToPlants (idx:int) (row:string) = [charToPlant row.[idx]; charToPlant row.[idx + 1]]

let plants (diagram: string) (student: string): Plant list = 
    let studentIdx = (List.findIndex ((=) student) students) * 2
    let rows = diagram.Split('\n') |> Array.toList
    rows |> List.collect (fun row -> rowToPlants studentIdx row)