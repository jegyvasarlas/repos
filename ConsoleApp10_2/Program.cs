namespace MyNamespace
{
    class MyClass
    {
        static void KeretRajzol(int w, int h)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("╔"); // 201
            //Felso es also keret
            for (int x = 1; x <= w-2; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("═"); //205
                Console.SetCursorPosition(x, h-1);
                Console.Write("═"); //205
            }
            Console.SetCursorPosition(w-1, 0);
            Console.Write("╗"); //187
            //Bal es jobb keret
            for (int y = 1; y <= h-2; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("║"); //186
                Console.SetCursorPosition(w-1, y);
                Console.Write("║"); //186
            }
            Console.SetCursorPosition(0, h-1);
            Console.Write("╚"); //200
            Console.SetCursorPosition(w-1, h - 1);
            Console.Write("╝"); //188
        }
        static void GolyoMozgatas(int poz_x, int poz_y, int w, int h, int ms=50)
        {
            Console.SetCursorPosition(poz_x, poz_y);
            Console.Write("O");
            bool x_irany = true; //true=x iranyba pozitiv
            bool y_irany = true; //true=y iranyba pozitiv
            while (true)
            {
                //varakozas
                Thread.Sleep(ms);
                //elozo karakter torles
                Console.SetCursorPosition(poz_x, poz_y);
                Console.Write(" ");
                //van e iranyvaltas
                if(poz_x == 1 && !x_irany || poz_x == w-2 && x_irany)
                    x_irany = !x_irany;
                if(poz_y == 1 && !y_irany || poz_y == h - 2 && y_irany)
                    y_irany = !y_irany;
                //hatarozzuk meg a kovetkezo poziciot
                if (x_irany)
                    poz_x++;
                else
                    poz_x--;
                if (y_irany)
                    poz_y++;
                else
                    poz_y--;
                //Uj pozicion kiirni a golyot
                Console.SetCursorPosition(poz_x, poz_y);
                Console.Write("O");
            }
        }
        static void Main()
        {
            //alapbeallitasok: hatter es kurzor
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor=ConsoleColor.White;
            //Szelesseg es magassag lekerdezese
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            //keret rajzolas
            KeretRajzol(width, height);
            GolyoMozgatas(10, 10, width, height, 50);
        }
    }
}
