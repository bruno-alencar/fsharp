module SpaceAge

// TODO: define the Planet type
type Planet = 
    member this.seconds = 2

type Earth =
    member this.seconds = 31557600
    member this.period = 365.25

type Mercury = 
    member this.period = 0.2408467

type Venus = 
    member this.period = 0.61519726

let age (planet: Planet) (seconds: int64): float = failwith "You need to implement this function."failwith "You need to implement this function."