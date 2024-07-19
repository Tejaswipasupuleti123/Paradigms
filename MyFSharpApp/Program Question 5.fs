// For more information see https://aka.ms/fsharp-console-apps
let numbers = Seq.toList { 1..700 }
let filteredNumbers = numbers |> List.filter (fun x -> x % 7 <> 0 && x % 5 <> 0)
let sumFiltered = List.reduce (+) filteredNumbers

printfn "Sum of numbers not multiples of 7 and 5: %d" sumFiltered

