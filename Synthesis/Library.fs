module Synthesis
(*
let abelar input = (3097 > input > 12) && (input%12 = 0) 
    failwith "Not implemented"
*)

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
(*
let ofTime hrs mins sec = (hrs*3600) + (mins*60) + sec
    failwith "Not implemented"
*)
let toTime sec = sec/3600,sec
    failwith "Not implemented"

let digits number = 
    failwith "Not implemented"

let minmax a b c d =
    match a<b with
    |true -> 
    |false ->
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