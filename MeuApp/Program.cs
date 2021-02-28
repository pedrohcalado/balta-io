using System;

namespace MeuApp
{
  class Program
  {
    static void Main(string[] args)
    {
      int valor = 1;
      float outro = 23.5F;
      double maisum = 23.1;
      decimal maisumoutro = 23.1M;
      string letra = "200";
      double inteiro = double.Parse(letra);
      uint npos = (uint)valor;
      outro = valor;
      // outro = maisum;
      // outro = letra;
      // letra = outro;
      Console.WriteLine(inteiro);
    }
  }
}
