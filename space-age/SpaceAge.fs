module SpaceAge
open System.Linq.Expressions
open Microsoft.VisualStudio.TestPlatform.ObjectModel
open System.Data.SqlTypes
open System.Security.Cryptography

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

 let age (planet: Planet) (seconds: int64): float = 
    match planet with
        | planet as Earth ->System.Math.Round( (seconds |> float) / (31557600 |> float), 2)
    