using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");

      Console.WriteLine("--------------");
      Console.WriteLine("Selecione uma opção");

      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 1: Sum(); break;
        case 2: Subtraction(); break;
        case 3: Division(); break;
        case 4: Multiplication(); break;
        default: Menu(); break;
      }
      Console.ReadKey();
    }
    static void Sum()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      double v1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      double v2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double soma = v1 + v2;

      Console.WriteLine($"O resultado da soma é {soma}");

      Console.ReadKey();
      Menu();
    }

    static void Subtraction()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float result = v1 - v2;
      Console.WriteLine($"O resultado da subtração é {result}");
      Console.ReadKey();
      Menu();
    }

    static void Division()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1 / v2;
      Console.WriteLine($"O resultado da divisão é {result}");

      Console.ReadKey();
      Menu();
    }

    static void Multiplication()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float result = v1 * v2;
      Console.WriteLine($"O resultado da muliplicação é {result}");

      Console.ReadKey();
      Menu();
    }
  }
}
