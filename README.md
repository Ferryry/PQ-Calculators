# PQ-Calculators
PQ Rechner in verschiedenen Sprachen

## Beispiel:

**C++:**
```cpp
std::cout << "x1 = " << pq(5, 5)[0] << std::endl;
std::cout << "x2 = " << pq(5, 5)[1] << std::endl;
```

**PHP:**
```php
echo sprintf("x1 = %f<br>x2 = %f", pq(5, 5)[0], pq(5, 5)[1]);
```

**C#:**
```cs
Console.WriteLine(string.Format("x1 = {0}\nx2 = {1}", pq(5, 5)[0], pq(5, 5)[1]));
```

**F#:**
```fs
//...
for i in pq(5.0, 5.0) do 
  printfn "%f\n" i
0
```
