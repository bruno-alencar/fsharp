module Leap

let perHundred (year: int): bool = 
            if year % 100 = 0 
            then false
            else true

let perFourHundred (year: int): bool =
            if year % 400 = 0 
            then true
            else perHundred year

let leapYear (year: int): bool = 
            if year % 4 = 0 
            then perFourHundred year
            else false
