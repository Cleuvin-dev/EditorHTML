using System;
using System.Text;

namespace EditorHTML
{
  public static class Editor
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("MODO EDITOR");
      Console.WriteLine("-----------");
      Start();
    }

    public static void Start()
    {

      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine()); // Adiciona o texto na tela
        file.Append(Environment.NewLine);

      } while (Console.ReadKey().Key != ConsoleKey.Escape); // Enquanto o usuario nao digitar a tecla ESC o mesmo permanecerá na tela de edição 

      Console.WriteLine("--------------");
      Console.WriteLine(" Deseja salvar o arquivo?");
      Viewer.Show(file.ToString());

    }
  }
}