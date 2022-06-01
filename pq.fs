open System

let pq(p : double, q : double) = 
    if (Math.Pow(p/2.0, 2.0) - q >= 0.0) then
        [|
            -p/2.0 - Math.Sqrt(Math.Pow(p/2.0, 2.0) - q);
            -p/2.0 + Math.Sqrt(Math.Pow(p/2.0, 2.0) - q)
        |]
    else
        raise(new Exception("Keine Nullstelle"))
