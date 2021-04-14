using System;
using System.Collections.Generic;

namespace CollectionDictionaryAndForEachUseCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            var dict = new Dictionary<int, int>();

            //prolezeme pole
            foreach (var value in array)
            {
                //prvni value, desitka, zatim prazdny slovnik, prvni if true nic, else prihodi do slovniku value deset a key jednicku
                //druhe kolo, petka, slovnik uz neni prazdny, uz je tam jeden key value par, 1 - 10, a ted se ulozi stejne jak predchozi kolo, key-value, 1-5
                //treti kolo desitka, ta uz ve slovniku je, tak tim "dict[10]++" se navysi key u desitky na dvojku, takze key value par bude u desitky, 2-10
                //a tak dale
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
           

            Console.WriteLine("");

            foreach (var pair in dict)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine("Toto cislo se v seznamu opakuje:   " + pair.Key  );
                }
            }

            Console.ReadKey();
        }
    }
}



