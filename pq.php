<?php
function pq($p, $q): array
{
  if(pow($p/2, 2) - $q >= 0)
    return array(-$p/2 - sqrt(pow($p/2, 2) - $q), -$p/2 + sqrt(pow($p/2, 2) - $q) );
  else
    die("Keine Nullstelle");
}
?>
