module SpaceAge
open System.Linq.Expressions
open Microsoft.VisualStudio.TestPlatform.ObjectModel
open System.Data.SqlTypes
open System.Security.Cryptography
open System;
open System.Runtime.CompilerServices
// TODO: define the Planet type

type Planet =
    | Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune
    member this.earth = float 31557600

    // Earth -> 31557600
    // | Mercury ->  0.2408467
    // | Venus -> 0.61519726
    // | Mars -> 1.8808158
    // | Jupiter -> 11.862615
    // | Saturn -> 29.447498
    // | Uranus -> 84.016846
    // | Neptune -> 164.79132

let round (value: float): float = 
    System.Math.Round(value, 2)

let age (planet: Planet) (seconds: int64): float = 
    match planet with
        | Neptune -> (seconds |> float) / (Neptune.earth * 164.79132)
        | Uranus -> (seconds |> float) / (Uranus.earth * 84.016846)
        | Saturn -> (seconds |> float) / (Saturn.earth * 29.447498)
        | Jupiter -> (seconds |> float) / (Jupiter.earth * 11.862615)
        | Mars -> (seconds |> float) / (Mars.earth * 1.8808158)
        | Venus -> (seconds |> float) / (Venus.earth * 0.61519726)
        | Mercury -> (seconds |> float) / (Mercury.earth * 0.2408467)
        | Earth ->  (seconds |> float) / Earth.earth
    |> round
       
    