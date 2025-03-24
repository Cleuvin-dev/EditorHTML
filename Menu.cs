using System;

namespace EditorHTML
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Green; // deixa fundo do console de verde
      Console.ForegroundColor = ConsoleColor.Black; // coloque a escrita na cor preta

      DrawScreen(); // Chamando a classe de desenho na tela
      WriteOptions();
      var option = short.Parse(Console.ReadLine());
      HandleMenuOption(option);
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

    public static void WriteOptions() // Classe que criar a opções dentro da tela para o usuario
    {
      Console.SetCursorPosition(3, 2); // função que coloca o curso para digitação na linha 3 apartir da coluna 2
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("==================");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma opção abaixo:");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3, 8);
      Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3, 10);
      Console.Write("Opção:");
    }

    public static void HandleMenuOption(short option) // Manipulando o menu
    {
      switch (option)
      {
        case 1: Editor.Show(); break;
        case 2: Console.WriteLine("View"); break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        default: Show(); break;
      }
    }


  }
}