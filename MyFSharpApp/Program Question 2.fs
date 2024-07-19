// For more information see https://aka.ms/fsharp-console-apps
let rec productOfList lst =
    match lst with
    | [] -> 1
    | head::tail -> head * productOfList tail

// Example usage
let myList = [2; 3; 4]
let result = productOfList myList
printfn "Product of list: %d" result   // Output: Product of list: 24
