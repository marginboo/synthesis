module Synthesis

let abelar b = b > 12 && b < 3097 && b % 12=0
    //failwith "Not implemented"

let area (a :float) (b :float) = 
    match (a < 0.0 ) || (b  < 0.0) with
    | true -> failwith "You Suck"
    | false -> 0.5 * (a * b)
    //failwith "Not implemented"

let zollo a = 
    match a > 0 with
    | true -> a* 2
    | false -> a * -1
    //failwith "Not implemented"

let min a b =
    match a > b with
    | true -> b
    | false -> a
    //failwith "Not implemented"

let max a b =
    match a > b with
    | true -> a 
    | false -> b
    //failwith "Not implemented"

let ofTime a b c = (*fun a -> fun b -> fun c ->*) (a*3600) + (b*60) + c
    //failwith "Not implemented"

let toTime _ =
    failwith "Not implemented"

let digits _ =
    failwith "Not implemented"

let minmax _ =
    failwith "Not implemented"

let isLeap _ =
    failwith "Not implemented"

let month _ =
    failwith "Not implemented"

let toBinary _ =
    failwith "Not implemented"

let bizFuzz _ =
    failwith "Not implemented"

let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"