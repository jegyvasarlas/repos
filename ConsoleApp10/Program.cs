namespace MyNamespace
{
	class MyClass
	{
		static void Main()
		{
            Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
            //max helyek
			int width = Console.WindowWidth;
			int height = Console.WindowHeight;
			Console.CursorVisible = false;
			//jelenlegi helyek
            int w = 1;
			int h = 1;
            //elozo helyek (last width & last height)
            int lw = 0; 
            int lh = 0;
            Console.SetCursorPosition(0, 0);
            Console.Write('╔');
            for (int i = 1; i < width; i++)
            {
                Console.Write('=');
            }
            for (int i = 0; i < height-2; i++)
            {
                Console.WriteLine('|');
            }
            Console.SetCursorPosition(0,height-1);
            Console.Write('╚');
            for (int db = 0; db < 2; db++)
			{
                for (int x = 1; x < height - 2; x++)
                {
                    lh = h;
                    lw = w;
                    h++;
                    w++;
                    Thread.Sleep(15);
                    Console.SetCursorPosition(w, h);
                    Console.WriteLine("o");
                    Console.SetCursorPosition(lw, lh);
                    Console.Write(" ");
                    
                }
                for (int x = height - 2; x > 1; x--)
                {
                    lh = h;
                    lw = w;
                    h--;
                    w++;
                    Thread.Sleep(15);
                    Console.SetCursorPosition(w, h);
                    Console.WriteLine("o");
                    Console.SetCursorPosition(lw, lh);
                    Console.Write(" ");
                    if (w == 233) { break; }
                }
            }
        }
	}
}
