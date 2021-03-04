using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Dictionary<string> isimler = new Dictionary<string>();

                isimler.Add("Seden");
                Console.WriteLine(isimler.Length);

                isimler.Add("Seymen");
                Console.WriteLine(isimler.Length);

                foreach (var isim in isimler.Items)
                {
                    Console.WriteLine(isim);
                }


            }

        }
    }
}
