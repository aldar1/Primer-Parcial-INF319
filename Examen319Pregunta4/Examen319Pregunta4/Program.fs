// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System
[<EntryPoint>]
let main argv = 
   

    let lista1 = [1..10]

    //let lista2 = []
    //let lista3 = []
    //let lista2 = [for i in 1..10 -> i]

    printf "Lista Original:   "
    for i in lista1 do
        printf "%i " i 

    let listapares = [for i in 1..10 do if i%2=0 then yield i]
    let listaimpares = [for i in 1..10 do if i%2=1 then yield i]

    printf "\nLista de numeros pares:  "
    for i in listapares do
        printf "%i " i 
    
    printf "\nLista de numeros impares:  "
    for i in listaimpares do
        printf "%i " i 



    Console.ReadKey() |>ignore
    0 // devolver un código de salida entero
