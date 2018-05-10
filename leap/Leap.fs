module Leap

let perFourHundred (year: int): bool =
            if year % 400 = 1 
            then false 
            else true

let perHundred (year: int): bool = 
            if year % 100 = 1 
            then false
            else perFourHundred year

let leapYear (year: int): bool = 
            if year % 4 = 0 
            then perHundred year
            else false
