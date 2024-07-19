// For more information see https://aka.ms/fsharp-console-apps
// Define the list of names
let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

// Trim whitespace from each name and print
printfn "Trimmed names:"
names
|> List.map (fun name -> name.Trim())
|> List.iter (fun trimmedName -> printfn "- %s" trimmedName)

