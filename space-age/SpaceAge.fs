module SpaceAge

// TODO: define the Planet type
type Planet = 
    member this.seconds = 2

type Earth =
    inherit Planet 
    member this.period = 365.25

type Mercury = 
    inherit Planet 
    member this.period = 0.2408467

type Venus = 
    inherit Planet 
    member this.period = 0.61519726


type Jupiter =
    inherit Planet 
    member this.period = 11.862615

type Saturn =
    inherit Planet 
    member this.period = 29.447498

type Uranus =
    inherit Planet 
    member this.period = 84.016846

type Neptune =
    inherit Planet 
    member this.period = 164.79132

let age (planet: Planet) (seconds: int64): float = failwith "You need to implement this function."failwith "You need to implement this function."