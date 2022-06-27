using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExchangeRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "E:/Valyuta.json";
            string data = File.ReadAllText(path);
            
            IList<Valyuta> valyutas = JsonConvert.DeserializeObject<List<Valyuta>>(data);

            //Valyuta valyuta1 = new Valyuta();
            //valyuta1.Title = "O'zbek so'mi";
            //valyuta1.Code = "UZS";
            //valyuta1.CbPrice = 1;
            //valyuta1.Date = "06.20.2022 09:00:01 am";
            //valyutas.Add(valyuta1);
            //string abduazim = JsonConvert.SerializeObject(valyutas);
            //File.WriteAllText(path, abduazim);



            for (int i = 0; i<valyutas.Count; i++ ) {
                Console.WriteLine(i + 1 +  ". " + valyutas[i].Title);
            }

            Console.WriteLine("\nValyuta Konvertatsiyasini amalga oshiraman!");
            Console.WriteLine("Yuqoridan o'zingizga mos valyutani tanlang");

            Console.Write("From ");
            int a = int.Parse(Console.ReadLine()) - 1;
            Console.Write("To ");
            int b = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Valyuta miqdorini kiriting");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine(c + " " + valyutas[a].Code + " = " + c * valyutas[a].CbPrice/ valyutas[b].CbPrice + " " + valyutas[b].Code);
        }
    }
}
