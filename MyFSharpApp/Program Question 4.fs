// For more information see https://aka.ms/fsharp-console-apps

let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

printfn "Trimmed names:"
names
|> List.map (fun name -> name.Trim())
|> List.iter (fun trimmedName -> printfn "- %s" trimmedName)

