module Accumulate

let accumulate<'a, 'b> (func: 'a -> 'b) (input: 'a list): 'b list =
    seq { for i in input then yield func }
    
    