namespace MyNamespace
{
	class MyClass
	{
        static Random random = new();
        static int EgyDobas()
		{
			return random.Next(1,7);
		}
        static int[] EzerDobas()
		{
			int[] dobasok = new int[1000];
			for (int i = 0; i < dobasok.Length; i++)
			{
				dobasok[i] = EgyDobas(); ;
            }
			return dobasok;
		}
		static void	Statisztika()
		{
			int[] db = new int[6] { 0, 0, 0, 0, 0, 0};
            int[] dobasok = EzerDobas();
			for (int i = 0; i < dobasok.Length; i++)
			{
				db[dobasok[i] - 1]++;
			}
			for (int i = 0; i < db.Length; i++)
			{
				Console.WriteLine((i+1) + ".: " + db[i]);
			}
        }
		static void Main()
		{
			Statisztika();
        }
	}
}