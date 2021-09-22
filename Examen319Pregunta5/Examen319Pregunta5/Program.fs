// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.



open System

let sumando1 m n =
    let mutable resultado = 0
    for i = 1 to n do
        resultado <- resultado + m
    resultado


let sumando2 m n =
    let rec loop x aux1 =
        if x = 0 then aux1
        else loop (x - 1) (aux1 + m)
    loop n 0



[<EntryPoint>]
let main argv = 

    let resultado = sumando2 2 20

    printf "El resultado de la multiplicacino con sumas sucesivas de 2 y 20 es :   "
    printfn "%i" resultado


    //--------------------- LECTURA POR TECLADO -------------------------
    //printf "Ingresar el primer numero  :   "
    //let a = System.Console.ReadLine()
    //let a = a |> int

    //printf "Ingresar el segundo numero  :   "
    //let b = System.Console.ReadLine()
    //let b = b |> int

    //let c = sumando1 a b

    //printf "Resultado con datos leidos   :   "
    //printf "%i" c 
    //----------------------------------------------------------------------
    

    Console.ReadKey() |>ignore
    0 // devolver un código de salida entero
