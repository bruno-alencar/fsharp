module ReverseString

let reverse (input: string): string = input |> Seq.rev |> String.concat |> String.First