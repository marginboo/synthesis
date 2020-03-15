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

let ofTime a b c =  (a*3600) + (b*60) + c
    //failwith "Not implemented"

let toTime time =
    match time < 0 with 
    |true -> (0,0,0)
    |false -> ( time / 60 ) / 60, ( time / 60 ) % 60 , time % 60
    //failwith "Not implemented"

let rec digits a = 
    match (a < 10 && a > (-10)) with 
    |true -> 1
    |false -> 1 + digits(a / 10)

let minmax (a,b,c,d) = min (min a b) (min c d) , max (max a b) (max c d)
    //failwith "Not implemented"

let isLeap year =
    match year < 1582 with
    |true -> failwith "Not implemented"
    |false -> year % 4 = 0 && not( year % 100 = 0) || year % 400 = 0 
    //match  year < 1582 && ((year % 4) = 0 ) && (year % 200 =0 ) with
    //| true
    //failwith "Not implemented"

let month a = 
    match a with |1 -> "January", 31 |2 ->"February",28|3 -> "March", 31 |4 -> "April", 30 |5 -> "May", 31 |6 -> "June", 30 |7 ->"July", 31 |8 -> "August", 31 |9 -> "September", 30|10 -> "October", 31 |11 -> "November", 30 |12 -> "December", 31 |_ ->failwith "Not implemented"

let toBinary nan =
    let rec conv num word = 
        match num with
        | 1 | 0 -> string num + word
        |_ -> conv (num / 2) ( string(num % 2 ) + word )
    match nan < 0 with 
    |true -> failwith "stop it please"
    |false -> conv nan ""
    //failwith "Not implemented"

let bizFuzz n =
    match n < 0 with 
    |true -> (0,0,0)
    |false -> (n / 3, n /5, n /15)               
    //failwith "Not implemented"

let monthDay d y =
    //match  d > 0 && d < 367 with 
    //| true -> match isLeap y with 
    match isLeap y with 
    |true -> match d < 367 && d > 0 with |false -> failwith "You loser" |true -> match d <= 31 with | true -> "January" |false -> match d <= 60 with |true -> "February"|false -> match d <= 91 with |true -> "March" | false -> match d <= 121 with | true -> "April" | false -> match d <= 152 with |true -> "May" | false -> match d <= 182 with |true -> "June" |false -> match d <= 213 with |true -> "July" | false -> match d <= 244 with |true -> "August" |false -> match d <= 274 with |true -> "September" |false -> match d <= 305 with |true -> "October" |false -> match d <= 335 with | true -> "November" |false -> "December"   
    |false -> match d < 366 && d > 0 with |false -> failwith "You loser" |true -> match d <= 31 with | true -> "January" |false -> match d <= 59 with |true -> "February"|false -> match d <= 90 with |true -> "March" | false -> match d <= 120 with | true -> "April" | false -> match d <= 151 with |true -> "May" | false -> match d <= 181 with |true -> "June" |false -> match d <= 212 with |true -> "July" | false -> match d <= 243 with |true -> "August" |false -> match d <= 273 with |true -> "September" |false -> match d <= 304 with |true -> "October" |false -> match d <= 334 with | true -> "November" |false -> "December"
    |_ -> failwith "We tried with you"
    //failwith "Not implemented"

let coord _ =
    failwith "Not implemented"