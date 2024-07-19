// For more information see https://aka.ms/fsharp-console-apps
let strings = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]
let filteredStrings = strings |> List.filter (fun name -> name.Contains("I"))
let concatenatedNames = List.fold (fun acc name -> acc + name) "" filteredStrings

printfn "Concatenated names containing 'I': %s" concatenatedNames
