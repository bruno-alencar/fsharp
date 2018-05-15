module Bob

let containsLetter (input: string): bool = input |> Seq.exists(fun c -> System.Char.IsLetter(c))

let response (input: string): string = 
        match input with
        | text when containsLetter(text) && text.ToUpper() = text && text.EndsWith("?") -> "Calm down, I know what I'm doing!"
        | text when containsLetter(text) && text.ToUpper() = text -> "Whoa, chill out!"
        | text when System.String.IsNullOrWhiteSpace text -> "Fine. Be that way!"
        | text when text.Trim().EndsWith("?") -> "Sure."
        | _ ->  "Whatever." 