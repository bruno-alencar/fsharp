module Accumulate

let accumulate<'a, 'b> (func: 'a -> 'b) (input: 'a list): 'b list =
    input then yield func
    
    