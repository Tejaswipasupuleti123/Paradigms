// For more information see https://aka.ms/fsharp-console-apps
let rec productOfOddNumbers n =
    if n <= 1 then n
    else if n % 2 = 0 then productOfOddNumbers (n - 1)
    else n * productOfOddNumbers (n - 2)

// Example usage
let result2 = productOfOddNumbers 11
printfn "Product of odd numbers from 11 to 1: %d" result2  
