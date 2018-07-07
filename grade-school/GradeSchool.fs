module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School = 
    match school.TryFind grade with
        | Some value -> school.Add (grade, (student :: value))
        | None -> school.Add(grade, [student])

let roster (school: School): (int * string list) list = school |> Map.toList

let grade (number: int) (school: School): string list =  
    match school.TryFind number with
        | Some value -> value
        | None -> []
