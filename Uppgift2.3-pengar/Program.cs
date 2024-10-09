using System;
namespace hoppa
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("hej,tack för att ni väljer Krebs bilar. jag gissar på att du vill hyra en bil?");
            string svar = Console.ReadLine();
            Console.WriteLine("bra. hur många dagar vill du ha bil?");
            int dagar = int.Parse(Console.ReadLine());
            Console.WriteLine("coolt. hur många km kommer du köra ungefär?");
            int km = int.Parse(Console.ReadLine());
            int pris = 300 + (1 * km) + ((dagar - 1) * 500);
            Console.WriteLine("här. pris = " + pris + "kr är vad det kommer kosta dig att få vår bil under en liten tid :)");
            



        }

    }

}