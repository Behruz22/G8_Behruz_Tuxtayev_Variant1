namespace ExaminProject_2_modul;

public class Worker
{

    public Worker()
    {
        Console.WriteLine("Restoranga xush kelibsiz!");
        Malumot mal= new Malumot();
        Kategoriyalar kat= new Kategoriyalar();
        Buyurtmalar buyurtma= new Buyurtmalar();
        Console.ReadKey();
        int cursor = 0;
        List<string> restoran = new List<string>() { "Restoran admini","Mijoz","Chiqish"};
        bool exit = true;
        while (exit)
        {
            Console.Clear();
            for(int i = 0; i < restoran.Count; i++)
            {
                if (cursor == i)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(restoran[i]);
                Console.ResetColor();
            }
            var consol = Console.ReadKey();
            if(consol.Key==ConsoleKey.DownArrow)
            {
                cursor=(cursor+1)%restoran.Count;
            }
            else if(consol.Key== ConsoleKey.UpArrow)
            {
                cursor=(cursor+restoran.Count-1)%restoran.Count;
            }
            else if(consol.Key==ConsoleKey.Enter)
            {
                switch (cursor)
                {
                    case 0:
                        int cursorAdmin = 0;
                        bool exitAdmin = true;
                        List<string> Admin= new List<string>() {"Restoran haqida ma'lumot","Kategoriyalar","Menyu","Buyurtmalar","Orqaga"};
                        while (exitAdmin)
                        {
                            Console.Clear();
                            Console.WriteLine("Admin");
                            for (int i = 0;i < Admin.Count; i++)
                            {
                                if (cursorAdmin == i)
                                {
                                    Console.BackgroundColor= ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }
                                Console.WriteLine(Admin[i]);
                                Console.ResetColor();
                            }
                            var consolAdmin= Console.ReadKey();
                            if (consolAdmin.Key == ConsoleKey.DownArrow)
                            {
                                cursorAdmin=(cursorAdmin+1)%Admin.Count;
                            }
                            else if(consolAdmin.Key == ConsoleKey.UpArrow)
                            {
                                cursorAdmin=(cursorAdmin+Admin.Count-1)%Admin.Count;
                            }
                            else if (consolAdmin.Key == ConsoleKey.Enter)
                            {
                                switch (cursorAdmin)
                                {
                                    case 0:
                                        int cursorMal = 0;
                                        bool exitMal = true;
                                        List<string> malumot = new List<string>() { "Ma'lumot kiritish", "Ma'lumotni yangilash", "Ma'lumotni o'chirish", "Ma'lumotni ko'rish", "Orqaga" };
                                        while (exitMal)
                                        {
                                            Console.Clear() ;
                                            Console.WriteLine("Admin");
                                            for(int i = 0; i < malumot.Count; i++)
                                            {
                                                if(cursorMal == i)
                                                {
                                                    Console.BackgroundColor= ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Black;
                                                }
                                                Console.WriteLine(malumot[i]);
                                                Console.ResetColor();
                                            }
                                            var consolMal= Console.ReadKey();
                                            if (consolMal.Key == ConsoleKey.UpArrow)
                                            {
                                                cursorMal = (cursorMal + Admin.Count - 1) % malumot.Count;
                                            }
                                            else if (consolMal.Key == ConsoleKey.DownArrow)
                                            {
                                                cursorMal = (cursorMal + 1) % malumot.Count;
                                            }
                                            else if(consolMal.Key== ConsoleKey.Enter)
                                            {
                                                switch (cursorMal)
                                                {
                                                    case 0:
                                                        mal.WriteMal();
                                                        Console.ReadKey();
                                                        break;
                                                     case 1:
                                                        mal.UpdateMal();
                                                        Console.ReadKey();
                                                        break;
                                                    case 2:
                                                        mal.DeleteMal();
                                                        Console.ReadKey();
                                                        break;
                                                    case 3:
                                                        mal.ListMal();
                                                        Console.ReadKey();
                                                        break;
                                                    case 4:
                                                        exitMal=false;
                                                        break;
                                                }
                                            }
                                        }
                                        break;
                                    case 1:
                                        int cursorKat = 0;
                                        bool exitKat = true;
                                        List<string> Kategoriya= new List<string>() {"Kategoriya yaratish","Kategoriyani o'zgartirish","Kategoriyani o'chirish","Kategoriya ro'yhati","Orqaga"};
                                        while (exitKat)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Admin");
                                            for(int i = 0;i < Kategoriya.Count; i++)
                                            {
                                                if (cursorKat == i)
                                                {
                                                    Console.BackgroundColor= ConsoleColor.White;
                                                    Console.ForegroundColor= ConsoleColor.Black;
                                                }
                                                Console.WriteLine(Kategoriya[i]);
                                                Console.ResetColor();
                                            }
                                            var consolKat=Console.ReadKey();
                                            if (consolKat.Key == ConsoleKey.DownArrow)
                                            {
                                                cursorKat=(cursorKat+1)%Kategoriya.Count;
                                            }
                                            else if (consolKat.Key == ConsoleKey.UpArrow)
                                            {
                                                cursorKat=(cursorKat+Kategoriya.Count-1)%Kategoriya.Count;
                                            }
                                            else if(consolKat.Key== ConsoleKey.Enter)
                                            {
                                                Console.Clear();
                                                switch (cursorKat)
                                                {
                                                    case 0:
                                                        kat.CreateKategoriya();
                                                        Console.ReadKey();
                                                        break;
                                                    case 1:
                                                        kat.UpdateKategoriya();
                                                        Console.ReadKey();
                                                        break;
                                                    case 2:
                                                        kat.DeleteKategoriya();
                                                        Console.ReadKey();
                                                        break;
                                                    case 3:
                                                        kat.ListKategoriya();
                                                        Console.ReadKey();
                                                        break;
                                                    case 4:
                                                        exitKat = false;
                                                        break;
                                                }
                                            }
                                        }
                                        break;
                                    case 2:
                                        kat.ListKategoriya();
                                        kat.Menyu();
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        buyurtma.Buyurtma();
                                        Console.ReadKey();

                                        break;
                                    case 4:
                                        exitAdmin = false;
                                        break;
                                }
                            }
                        }
                        break;
                    case 1:
                        int cursorMijoz = 0;
                        bool exitMijoz=true;
                        List<string> Mijoz = new List<string>() {"Restoran haqida ma'lumot","Buyurtma berish","Buyurtmalarim","Orqaga"};
                        while (exitMijoz)
                        {
                            Console.Clear();
                            for(int i = 0; i < Mijoz.Count; i++)
                            {
                                if (cursorMijoz == i)
                                {
                                    Console.BackgroundColor=ConsoleColor.White;
                                    Console.ForegroundColor=ConsoleColor.Black;
                                }
                                Console.WriteLine(Mijoz[i]);
                                Console.ResetColor();
                            }
                            var consolMijoz=Console.ReadKey();
                            if (consolMijoz.Key == ConsoleKey.DownArrow)
                            {
                                cursorMijoz=(cursorMijoz+1)%Mijoz.Count;
                            }
                            else if (consolMijoz.Key == ConsoleKey.UpArrow)
                            {
                                cursorMijoz=(cursorMijoz+Mijoz.Count-1)%Mijoz.Count;
                            }
                            else if(consolMijoz.Key== ConsoleKey.Enter)
                            {
                                switch (cursorMijoz)
                                {
                                    case 0:
                                        mal.ListMal();
                                        Console.ReadKey();
                                        break;
                                    case 1:

                                        break;
                                    case 2:
                                        break;
                                    case 3:
                                        exitMijoz = false;
                                        break;

                                }
                            }
                        }

                        break;
                    case 2:
                        exit= false;
                        break;
                }
            }
        }
    }
}
