module Raindrops

let isDivisible (number: int) (value: int): bool = 
        number % value = 0 

let convert (number: int): string = 
    [1..number]
    |> isDivisible number