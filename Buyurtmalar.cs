
using System.Text.Json;

namespace ExaminProject_2_modul;

public class Buyurtmalar
{
    string buyurtmalar = Directory.GetCurrentDirectory()+"Buyurtmalar.json";
    string menuPath = Directory.GetCurrentDirectory() + "Menyu.json";
    public void Buyurtma()
    {
        List<Dictionary<string, List<string>>> menu = new List<Dictionary<string, List<string>>>();
        if(File.Exists(menuPath))
        {
            using(StreamReader sr = new StreamReader(menuPath))
            {
                menu=JsonSerializer.Deserialize<List<Dictionary<string, List<string>>>>(sr.ReadToEnd());
            }
            int i = 0;
            foreach(var item in menu)
            {
                foreach (var key in item)
                {
                    Console.Write($"{++i}. {key.Key}: ");
                    foreach(var value in key.Value)
                    {
                        Console.Write(value+" ");
                    }
                    Console.WriteLine("\n");
                }
            }
            Console.Write("Kategoriyani tanlang: ");
            int cat = int.Parse(Console.ReadLine());
            int j = 0;
            Console.Write("Taomni tanlang: ");
            foreach (var item in menu[cat - 1])
            {
                foreach(var key in item.Value)
                {
                    Console.WriteLine($"{++j}.{key}");
                }
            }
            int taomId=int.Parse(Console.ReadLine());
            string newTaom;
            int n = 0;
            foreach (var item in menu[cat - 1])
            {
                foreach (var key in item.Value)
                {
                    if (taomId == (++n))
                    {
                        Console.WriteLine(key);
                    }
                }
            }
            

        }
        else
        {
            Console.WriteLine("Afsuski hali menyu mavjud emas!");
        }
    }
}
