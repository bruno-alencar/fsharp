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
    member this.seconds = 31557600
 let age (planet: Planet) (seconds: int64): float = 
    math