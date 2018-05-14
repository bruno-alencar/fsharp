module Bob

let response (input: string): string = 
        match input with
        | text when text.ToUpper() = text && text.EndsWith("?") -> "Calm down, I know what I'm doing!"
        | text when text.ToUpper() -> "Whoa, chill out!"
        | text when text.EndsWith("?") -> "Sure."
        | _ ->  "Whatever." 