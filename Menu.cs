using System;

namespace EditorHTML
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Blue; // deixa fundo do console de azul
      Console.ForegroundColor = ConsoleColor.Black; // coloque a escrita na cor preta

      DrawScreen(); // Chamando a classe de desenho na tela
    }

    public static void DrawScreen() // Classe para criar um desenho na tela do usuario
    {
      // Desenha a parte superior da tela
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");

      // Desenha as linhas laterias da tela
      for (int lines = 0; lines <= 10; lines++)
      {
        Console.Write("|");
        for (int i = 0; i <= 30; i++)
          Console.Write(" ");

        Console.Write("|");
        Console.Write("\n");
      }

      // Desenha a parte inferior da tela
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");





    }
  }
}