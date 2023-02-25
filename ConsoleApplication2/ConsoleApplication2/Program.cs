using System;
using System.Linq;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Vonal();
            Megallo();
            //Szolnok();
        }
        public static void Vonal()
        {
            int hourone = 5;
            int hourtwo = 6;
            int honnan = 32;
            int hova = 1;
            string indulperc = "10";
            string erkezperc = "52";
            string nev = "Z50";
            Console.WriteLine("insert into vonal (honnan, hova, nev, indul, erkez) VALUES ");
            while (hourtwo < 10)
            {
                Console.WriteLine($"({honnan}, {hova}, '{nev}', '0{hourone}:{indulperc}:00', '0{hourtwo}:{erkezperc}:00'),");
                hourone++;
                hourtwo++;
            }
            while (hourtwo < 24)
            {
                Console.WriteLine($"({honnan}, {hova}, '{nev}', '{hourone}:{indulperc}:00', '{hourtwo}:{erkezperc}:00'),");
                hourone++;
                hourtwo++;
            }

        }
        public static int[] reverse(int[] array)
        {
            int[] reversed = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - i - 1];
            }
            return reversed;
        }
        public static int[] kmsReverse(int[] array)
        {
            int[] reversed = new int[array.Length];
            int maxValue = array.Select(x => x).Max();
            int minValue = array.Select(x => x).Min();
            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = maxValue - array[i] + minValue;
            }
            int[] tmp = reverse(reversed);
            return tmp;
        }
        public static void Megallo()
        {
            int hourone = 5;
            int hourtwo = 6;
            int hourthree = 6;
            int vonal = 127;
            int[] megalloneveka = { 1, 2, 3, 15, 18, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
            int[] megallonevek = reverse(megalloneveka);
            int[] kms = { 0, 5, 7, 11, 17, 39, 45, 49, 56, 63, 64, 68, 74, 95, 107 };
            Console.WriteLine("insert into megallo (vonal, megallo, erkez, indul, km) VALUES ");
            while (hourthree < 24)
            {
                Console.WriteLine($"({vonal}, {megallonevek[0]}, NULL, '{hourone}:10:00', {kms[0]}),"); 
                Console.WriteLine($"({vonal}, {megallonevek[1]}, '{hourone}:20:00', '{hourone}:21:00', {kms[1]}),");
                Console.WriteLine($"({vonal}, {megallonevek[2]}, '{hourone}:31:00', '{hourone}:33:00',  {kms[2]}),");
                Console.WriteLine($"({vonal}, {megallonevek[3]}, '{hourone}:38:00', '{hourone}:39:00', {kms[3]}),");
                Console.WriteLine($"({vonal}, {megallonevek[4]}, '{hourone}:42:00', '{hourone}:43:00', {kms[4]}),");
                Console.WriteLine($"({vonal}, {megallonevek[5]}, '{hourone}:45:00', '{hourone}:46:00', {kms[5]}),");
                Console.WriteLine($"({vonal}, {megallonevek[6]}, '{hourone}:49:00', '{hourone}:50:00', {kms[6]}),");
                Console.WriteLine($"({vonal}, {megallonevek[7]}, '{hourone}:55:00', '{hourone}:56:00', {kms[7]}),");
                Console.WriteLine($"({vonal}, {megallonevek[8]}, '{hourone}:59:00', '{hourtwo}:00:00', {kms[8]}),");
                Console.WriteLine($"({vonal}, {megallonevek[9]}, '{hourtwo}:05:00', '{hourtwo}:07:00', {kms[9]}),");
                Console.WriteLine($"({vonal}, {megallonevek[10]}, '{hourtwo}:26:00', '{hourtwo}:27:00', {kms[10]}),");
                Console.WriteLine($"({vonal}, {megallonevek[11]}, '{hourtwo}:35:00', '{hourtwo}:36:00', {kms[11]}),");
                Console.WriteLine($"({vonal}, {megallonevek[12]}, '{hourthree}:39:00', '{hourthree}:40:00', {kms[12]}),");
                Console.WriteLine($"({vonal}, {megallonevek[13]}, '{hourthree}:44:00', '{hourthree}:45:00', {kms[13]}),");
                Console.WriteLine($"({vonal}, {megallonevek[14]}, '{hourthree}:52:00', NULL, {kms[14]}),");
                vonal++;
                hourone++;
                hourtwo++;
                hourthree++;
            }
        }
        public static void Szolnok()
        {
            int hourone = 3;
            int hourtwo = 4;
            int vonal = 107;
            int[] megalloneveka = { 1, 2, 3, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
            int[] megallonevek = reverse(megalloneveka);
            Console.WriteLine("insert into megallo (vonal, megallo, erkez, indul, km) VALUES ");
            Console.WriteLine($"({vonal}, {megallonevek[0]}, NULL, '0{hourone}:10:00', 0),"); 
            Console.WriteLine($"({vonal}, {megallonevek[1]}, '0{hourone}:20:00', '0{hourone}:21:00', 12),");
            Console.WriteLine($"({vonal}, {megallonevek[2]}, '0{hourone}:31:00', '0{hourone}:33:00',  33),");
            Console.WriteLine($"({vonal}, {megallonevek[3]}, '0{hourone}:38:00', '0{hourone}:39:00', 39),");
            Console.WriteLine($"({vonal}, {megallonevek[4]}, '0{hourone}:42:00', '0{hourone}:43:00', 43),");
            Console.WriteLine($"({vonal}, {megallonevek[5]}, '0{hourone}:45:00', '0{hourone}:46:00', 44),");
            Console.WriteLine($"({vonal}, {megallonevek[6]}, '0{hourone}:49:00', '0{hourone}:50:00', 51),");
            Console.WriteLine($"({vonal}, {megallonevek[7]}, '0{hourone}:55:00', '0{hourone}:56:00', 58),");
            Console.WriteLine($"({vonal}, {megallonevek[8]}, '0{hourone}:59:00', '0{hourtwo}:00:00', 62),");
            Console.WriteLine($"({vonal}, {megallonevek[9]}, '0{hourtwo}:05:00', '0{hourtwo}:07:00', 68),");
            Console.WriteLine($"({vonal}, {megallonevek[10]}, '0{hourtwo}:11:00', '0{hourtwo}:11:00', 72),");
            Console.WriteLine($"({vonal}, {megallonevek[11]}, '0{hourtwo}:14:00', '0{hourtwo}:15:00', 75),");
            Console.WriteLine($"({vonal}, {megallonevek[12]}, '0{hourtwo}:19:00', '0{hourtwo}:20:00', 84),");
            Console.WriteLine($"({vonal}, {megallonevek[13]}, '0{hourtwo}:22:00', '0{hourtwo}:23:00', 85),");
            Console.WriteLine($"({vonal}, {megallonevek[14]}, '0{hourtwo}:26:00', '0{hourtwo}:27:00', 90),");
            Console.WriteLine($"({vonal}, {megallonevek[15]}, '0{hourtwo}:29:00', '0{hourtwo}:29:00', 91),");
            Console.WriteLine($"({vonal}, {megallonevek[16]}, '0{hourtwo}:31:00', '0{hourtwo}:32:00', 94),");
            Console.WriteLine($"({vonal}, {megallonevek[17]}, '0{hourtwo}:35:00', '0{hourtwo}:36:00', 96),");
            Console.WriteLine($"({vonal}, {megallonevek[18]}, '0{hourtwo}:39:00', '0{hourtwo}:40:00', 100),");
            Console.WriteLine($"({vonal}, {megallonevek[19]}, '0{hourtwo}:44:00', '0{hourtwo}:45:00', 102),");
            Console.WriteLine($"({vonal}, {megallonevek[20]}, '0{hourtwo}:52:00', NULL, 107),");
            hourone = 13;
            hourtwo = 14;
            vonal = 108;
            Console.WriteLine($"({vonal}, {megallonevek[0]}, NULL, '0{hourone}:10:00', 0),"); 
            Console.WriteLine($"({vonal}, {megallonevek[1]}, '0{hourone}:20:00', '0{hourone}:21:00', 12),");
            Console.WriteLine($"({vonal}, {megallonevek[2]}, '0{hourone}:31:00', '0{hourone}:33:00',  33),");
            Console.WriteLine($"({vonal}, {megallonevek[3]}, '0{hourone}:38:00', '0{hourone}:39:00', 39),");
            Console.WriteLine($"({vonal}, {megallonevek[4]}, '0{hourone}:42:00', '0{hourone}:43:00', 43),");
            Console.WriteLine($"({vonal}, {megallonevek[5]}, '0{hourone}:45:00', '0{hourone}:46:00', 44),");
            Console.WriteLine($"({vonal}, {megallonevek[6]}, '0{hourone}:49:00', '0{hourone}:50:00', 51),");
            Console.WriteLine($"({vonal}, {megallonevek[7]}, '0{hourone}:55:00', '0{hourone}:56:00', 58),");
            Console.WriteLine($"({vonal}, {megallonevek[8]}, '0{hourone}:59:00', '0{hourtwo}:00:00', 62),");
            Console.WriteLine($"({vonal}, {megallonevek[9]}, '0{hourtwo}:05:00', '0{hourtwo}:07:00', 68),");
            Console.WriteLine($"({vonal}, {megallonevek[10]}, '0{hourtwo}:11:00', '0{hourtwo}:11:00', 72),");
            Console.WriteLine($"({vonal}, {megallonevek[11]}, '0{hourtwo}:14:00', '0{hourtwo}:15:00', 75),");
            Console.WriteLine($"({vonal}, {megallonevek[12]}, '0{hourtwo}:19:00', '0{hourtwo}:20:00', 84),");
            Console.WriteLine($"({vonal}, {megallonevek[13]}, '0{hourtwo}:22:00', '0{hourtwo}:23:00', 85),");
            Console.WriteLine($"({vonal}, {megallonevek[14]}, '0{hourtwo}:26:00', '0{hourtwo}:27:00', 90),");
            Console.WriteLine($"({vonal}, {megallonevek[15]}, '0{hourtwo}:29:00', '0{hourtwo}:29:00', 91),");
            Console.WriteLine($"({vonal}, {megallonevek[16]}, '0{hourtwo}:31:00', '0{hourtwo}:32:00', 94),");
            Console.WriteLine($"({vonal}, {megallonevek[17]}, '0{hourtwo}:35:00', '0{hourtwo}:36:00', 96),");
            Console.WriteLine($"({vonal}, {megallonevek[18]}, '0{hourtwo}:39:00', '0{hourtwo}:40:00', 100),");
            Console.WriteLine($"({vonal}, {megallonevek[19]}, '0{hourtwo}:44:00', '0{hourtwo}:45:00', 102),");
            Console.WriteLine($"({vonal}, {megallonevek[20]}, '0{hourtwo}:52:00', NULL, 107)");
        }
    }
}