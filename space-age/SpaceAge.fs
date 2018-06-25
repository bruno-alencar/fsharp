module SpaceAge
open System.Linq.Expressions
open Microsoft.VisualStudio.TestPlatform.ObjectModel
open System.Data.SqlTypes
open System.Security.Cryptography
open System;
open System.Runtime.CompilerServices
// TODO: define the Planet type

type Planet =
    | Earth -> 31557600
    | Mercury ->  0.2408467
    | Venus -> 0.61519726
    | Mars -> 1.8808158
    | Jupiter -> 11.862615
    | Saturn -> 29.447498
    | Uranus -> 84.016846
    | Neptune -> 164.79132
    member this.earth = float 31557600

let round (value: float): float = 
    System.Math.Round(value, 2)

let age (planet: Planet) (seconds: int64): float = 
    match planet with
        | Mercury -> (seconds |> float) / (Mercury.earth * 0.2408467)
        | Earth ->  (seconds |> float) / Earth.earth
    |> round
       
    