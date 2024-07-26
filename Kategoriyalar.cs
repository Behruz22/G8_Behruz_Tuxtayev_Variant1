using System.Text.Json;

namespace ExaminProject_2_modul;

public class Kategoriyalar
{
    string katPath=Directory.GetCurrentDirectory()+"Kategoriya.json";
    public void CreateKategoriya() 
    {
        Console.Write("Kategoriyani kiriting:");
        string name = Console.ReadLine();
        if (!string.IsNullOrEmpty(name))
        {
            List<Kategoriya> kategoriyas  = new List<Kategoriya>();

            if (File.Exists(katPath))
            {
                using (StreamReader streamReader = new StreamReader(katPath))
                {
                    kategoriyas = JsonSerializer.Deserialize<List<Kategoriya>>(streamReader.ReadToEnd());

                }
            }
            int newId = kategoriyas.Count > 0 ? kategoriyas.Max(m => m.id) + 1 : 1;
            kategoriyas.Add(new Kategoriya { id = newId, name = name });
            using (StreamWriter writer = new StreamWriter(katPath))
            {
                writer.WriteLine(JsonSerializer.Serialize<List<Kategoriya>>(kategoriyas));
            }
            Console.WriteLine("Muvaffaqiyatli qo'shildi!");
        }
        else
        {
            Console.WriteLine("Bo'sh ma'lumot kiriitsh mumkin emas!");
        }
    }
    public void DeleteKategoriya()
    {
        if (File.Exists(katPath))
        {
            Console.Write("O'chirmoqchi bo'lgan kategoriya id sini kiriting: ");
            int newId;
            bool idTF = int.TryParse(Console.ReadLine(), out newId);
            if (idTF)
            {
                List<Kategoriya> kat = new List<Kategoriya>();
                using (StreamReader reader = new StreamReader(katPath))
                {
                    kat = JsonSerializer.Deserialize<List<Kategoriya>>(reader.ReadToEnd());
                }
                var k = kat.FirstOrDefault(k => k.id == newId);
                if (k != null)
                {
                    kat.Remove(k);
                    using (StreamWriter writer = new StreamWriter(katPath))
                    {
                        writer.WriteLine(JsonSerializer.Serialize<List<Kategoriya>>(kat));
                    }
                    Console.WriteLine("Muvaffaqiyatli o'chirildi!");
                }
                else
                {
                    Console.WriteLine("Bunaqa id li kategoriya mavjud emas!");
                }
            }
            else
            {
                Console.WriteLine("Xato ma'lumot kiritayapsiz!");
            }
        }
        else
        {
            Console.WriteLine("Afsuski sizda hali kategoriyalar mavjud emas!");
        }
    }
    public void UpdateKategoriya() 
    {
        if (File.Exists(katPath))
        {
            Console.Write("O'zgartirmoqchi bo'lgan kategoriya id sini kiriting: ");
            int newId;
            bool idTF = int.TryParse(Console.ReadLine(), out newId);
            if (idTF)
            {
                List<Kategoriya> kat = new List<Kategoriya>();
                using (StreamReader reader = new StreamReader(katPath))
                {
                    kat = JsonSerializer.Deserialize<List<Kategoriya>>(reader.ReadToEnd());
                }
                var k = kat.FirstOrDefault(k => k.id == newId);
                if (k != null)
                {
                    Console.Write("Yangi kategoriya nomini kiriting: ");
                    k.name = Console.ReadLine();
                    using (StreamWriter writer = new StreamWriter(katPath))
                    {
                        writer.WriteLine(JsonSerializer.Serialize<List<Kategoriya>>(kat));
                    }
                    Console.WriteLine("Muvaffaqiyatli o'zgartirildi!");
                }
                else
                {
                    Console.WriteLine("Bunaqa id li kategoriya mavjud emas!");
                }
            }
            else
            {
                Console.WriteLine("Xato ma'lumot kiritayapsiz!");
            }
        }
        else
        {
            Console.WriteLine("Afsuski sizda hali kategoriyalar mavjud emas!");
        }

    }
    public void ListKategoriya() 
    {
        if (File.Exists(katPath))
        {
            List<Kategoriya> kat = new List<Kategoriya>();
            using (StreamReader reader = new StreamReader(katPath))
            {
                kat = JsonSerializer.Deserialize<List<Kategoriya>>(reader.ReadToEnd());
            }
            foreach (var item in kat)
            {
                Console.WriteLine($"{item.id}: {item.name}");
            }

        }
        else
        {
            Console.WriteLine("Afsuski sida hali kategoriyalar mavjud emas!");
        }

    }

    public void Menyu()
    {
        string menuPath=Directory.GetCurrentDirectory()+"Menyu.json";
        List<Dictionary<string,List<string>>> menu=new List<Dictionary<string, List<string>>>();
        Dictionary<string,List<string>> keyValuePairs = new Dictionary<string,List<string>>();

        if(File.Exists(menuPath))
        {
            using(StreamReader reader = new StreamReader(menuPath))
            {
                menu=JsonSerializer.Deserialize<List<Dictionary<string, List<string>>>>(reader.ReadToEnd());
            }
        }
        Console.Write("Kategoriya id sini kiriting: ");
        int id;
        bool idTF = int.TryParse(Console.ReadLine(), out id);
        if (idTF)
        {
            List<Kategoriya> kat = new List<Kategoriya>();
            using (StreamReader r = new StreamReader(katPath))
            {
                kat = JsonSerializer.Deserialize<List<Kategoriya>>(r.ReadToEnd());
            }
            var k = kat.FirstOrDefault(m => m.id == id);
            if (k != null)
            {
                List<string> taomlar = new List<string>();
                bool exit = true;
                while (exit)
                {

                    Console.Write("Taomni kiriting: ");
                    taomlar.Add(Console.ReadLine());
                    Console.WriteLine("1.Yana kiritish\n2.Yetarli");
                    int choice;
                    bool ch = int.TryParse(Console.ReadLine(), out choice);
                    if (ch)
                    {
                        switch (choice)
                        {
                            case 1:
                                break;
                            case 2:
                                exit = false;
                                break;
                            default:
                                Console.WriteLine("Noto'g'ri urunish!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Xato ma'lumot!");
                    }

                }
                keyValuePairs.Add(k.name, taomlar);
                menu.Add(keyValuePairs);
                using(StreamWriter writer =new StreamWriter(menuPath))
                {
                    writer.WriteLine(JsonSerializer.Serialize<List<Dictionary<string, List<string>>>>(menu));
                }
                Console.WriteLine("Qo'shildi!");
            }
            else
            {
                Console.WriteLine("Bunaqa id li kategoriya mavjud emas!");
            }
        }
        else
        {
            Console.WriteLine("Xato ma'lumot kiritayapsiz!");
        }

    }

}
