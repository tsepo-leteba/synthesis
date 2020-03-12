module Synthesis

let abelar input = (input > 12) && (input < 3097) && (input%12 = 0) 


let area b h =
    match b < 0.0 || h < 0.0 with
    |true -> failwith "Negative breadth or height given"
    |false -> (b*h)/2.0
    |_ ->
    failwith "Not implemented"

let zollo input =
    match input < 0 with
    |true -> -1*input
    |false -> input*2
    |_ ->
    failwith "Not implemented"

let min a b =
    match a < b with
    |true -> a
    |false -> b
    |_ ->
    failwith "Not implemented"

let max a b =
    match a < b with
    |true -> b
    |false -> a
    |_ ->
    failwith "Not implemented"

let ofTime hrs mins sec = (hrs*3600) + (mins*60) + sec

let toTime sec = 
    let hrs = sec/3600
    let remaining = (sec - (hrs*3600))
    let mins = remaining/60
    let secs = remaining - (mins*60)
    (hrs,mins,secs)
(*
let digits number = 
    match number < 0 with
    |true -> nu
    let rec divideby10 n acc=
        match n/10 > 0 with
        |true -> divideby10 n/10 acc+1
        |false -> acc
*)

let digits number =
    let rec divideby10 num acc =
        match num/10 < 0 with
        |true -> acc        
        |_ -> divideby10 (num/10) (acc+1)
    match number < 0 with
    |true -> divideby10 (-1*number) 0   //if number is negative negate it and call recursive function
    |_ -> divideby10 number 0
    


let minmax (a,b,c,d) = 

    failwith "Not implemented"

let isLeap _ =
    failwith "Not implemented"

let month num = 
    match num with
    |1 -> ("January",31)
    |2 -> ("February",28)
    |3 -> ("March",31)
    |4 -> ("April",30)
    |5 -> ("May",31)
    |6 -> ("June",30)
    |7 -> ("July",31)
    |8 -> ("August",31)
    |9 -> ("September",30)
    |10 -> ("October",31)
    |11 -> ("November",30)
    |12 -> ("December",31)
    |_ -> failwith "its Late Ma Boi"

let toBinary _ =
    failwith "Not implemented"

let bizFuzz _ =
    failwith "Not implemented"

let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"