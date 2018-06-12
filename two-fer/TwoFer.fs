module TwoFer

    let parameters (first: string) = "One for "+first+", one for me." 

    let twoFer (input: string option): string =
        match input with
        | None -> parameters "you"
        | _ -> parameters input.Value