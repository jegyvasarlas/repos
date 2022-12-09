using System;

namespace Kivetelkezeles
{
    class Program
    {
        public static double Test(int x, int y)
        {
            double eredmeny;
            if (y == 0)
                throw new MyException("Nullaval nem lehet osztani");
            eredmeny = x / y;
            return eredmeny;
        }

        public static void Test2(string s)
        {
            try
            {
                if (s == string.Empty)
                    throw new MyException("Ures a string!");
            }
            catch
            {
                throw;
            }
                
        }
        
        static void Main()
        {
            int[] tomb = new int[4];
            try
            {
                tomb[4] = 12;
                Console.WriteLine(tomb[2]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Tulindexelesi hiba!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Egyeb hiba");
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("Ismeretlen hiba");
            }
            finally
            {
                Console.WriteLine("Ez mindig lefut");
            }
            Console.WriteLine("Ez is lefut");
            try
            {
                Test(2, 3);
                Test(5, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Test2("");
        }
    }
}
