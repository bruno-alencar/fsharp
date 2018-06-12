module TwoFer

    let twoFer (input: string option): string =
        match input with
            | None -> "you"
            | Some value -> value
            |> sprintf "One for %s, one for me." 