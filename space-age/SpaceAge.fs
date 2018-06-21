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


let age (planet: Planet) (seconds: int64): float = 
    match planet with
        | Mercury -> System.Math.Round((seconds |> float) / (Mercury.earth * 0.2408467), 2)
        | Earth -> System.Math.Round( (seconds |> float) / Earth.earth , 2)

       
    