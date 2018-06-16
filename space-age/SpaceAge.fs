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
    

// type Planet = 
//     new () = {}
//     member this.seconds = 2

// type Earth =
//     inherit Planet 
//     new () = {}
//     member this.period = 365.25

// type Mercury = 
//     inherit Planet 
//     new () = {}
//     member this.period = 0.2408467

// type Venus = 
//     inherit Planet 
//     new () = {}
//     member this.period = 0.61519726


// type Jupiter =
//     inherit Planet 
//     new () = {}
//     member this.period = 11.862615

// type Saturn =
//     inherit Planet 
//     new () = {}
//     member this.period = 29.447498

// type Uranus =
//     inherit Planet 
//     new () = {}
//     member this.period = 84.016846

// type Neptune =
//     inherit Planet 
//     new () = {}
//     member this.period = 164.79132

let age (planet: Planet) (seconds: int64): float = 
