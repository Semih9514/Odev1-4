using System;

namespace Odev1_4
{
    public class Program
    {
        public static void Main(string[] args)
        {

        Console.Write("Cumle Giriniz:");
        string cumle = Console.ReadLine();

        string[] dizi ;
        dizi = cumle.Split(' ');

        string liste  = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ" + "abcçdefgğhiıjklmnoöprsştuüvyz";
        int sayac = 0;
        int t = 0;

        foreach (var kelime in dizi)
        {
            Console.WriteLine(kelime);
            t++;
        }

        for (int i = 0; i < cumle.Length; i++)
        {
            if (liste.Contains(cumle[i]))
            {
                sayac++;
            }
        }
        Console.WriteLine("{0} tane  harf vardır.", sayac);
        Console.WriteLine("{0} tane  kelime vardır.", t);
        }
    }
}
