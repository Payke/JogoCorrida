
class Progran
{
    static void Main()
    {
        
        Console.WriteLine("IFSP");

        var posicao = "Left";

        for (; ;) {
            
            DesenharCenario();
            DesenharElemento(2, 6, '0');
            DesenharElemento(4, 17, '0');
            DesenharElemento(10, posicao == "Left" ? 6 : 17, '8');

            if (Console.KeyAvailable)
            {
                var tecla = Console.ReadKey();
                Console.WriteLine(tecla.Key.ToString());
                if(tecla.Key == ConsoleKey.LeftArrow)
                {
                    posicao = "Left";

                }
                else if (tecla.Key == ConsoleKey.RightArrow)
                {
                    posicao = "Rigth";
                }
            }

            Thread.Sleep(100);

            if (posicao == "Left")
            {
                DesenharElemento(10, 6, '8');
            }
            else
            {
                DesenharElemento(10, 17, '8');
            }

        }
    }

    public static void DesenharElemento(int linha, int coluna, char simbolo)
    {
        var xOriginal = Console.CursorLeft;
        var yOriginal = Console.CursorTop;
        Console.SetCursorPosition(coluna, linha);
        Console.Write(simbolo.ToString());
        Console.SetCursorPosition(xOriginal, yOriginal);

    }

    public static void DesenharCenario()
    {
        Console.Clear();
        Console.WriteLine("+----------+----------+\r\n");
        Console.WriteLine("|          |          | \r\n");
        Console.WriteLine("|          |          | \r\n");
        Console.WriteLine("|          |          | \r\n");
        Console.WriteLine("|          |          | \r\n");
        Console.WriteLine("|          |          | \r\n");
        Console.WriteLine("|          |          | \r\n");
        Console.WriteLine("|          |          | \r\n");
        Console.WriteLine("|          |          | \r\n");
        Console.WriteLine("|          |          | \r\n");
        Console.WriteLine("+----------+----------+\r\n");

    }

}