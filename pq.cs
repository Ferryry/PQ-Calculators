public static double[] pq(double p, double q)
{
  if(Math.Pow(p/2, 2) - q >= 0)
    return new double[] {
      -p/2 - Math.Sqrt(Math.Pow(p/2, 2) - q ),
      -p/2 + Math.Sqrt(Math.Pow(p/2, 2) - q )
    };
   else throw new Exception("Keine Nullstelle!");
}
