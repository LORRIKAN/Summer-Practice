using System;

namespace Kinetics
{
  class Configurate
  {
    internal static double ToFixed(double number, uint decimals) // Округления до заданного числа 
    {
      string str =  number.ToString("N" + decimals);
      return Convert.ToDouble(str);
    }
  }
}
