namespace ExaminProject_2_modul;

public class Malumot
{
    string malPath=Directory.GetCurrentDirectory()+"Malumot.txt";
    public void WriteMal() 
    {
        if(!File.Exists(malPath))
        {
            Console.Write("Ma'lumotni kiriting: ");
            string text=Console.ReadLine();
            if(text != null)
            {
                using(StreamWriter writer=new StreamWriter(malPath))
                {
                    writer.WriteLine(text);
                }
                Console.WriteLine("Ma'lumot qo'shildi!");
            }
            else
            {
                Console.WriteLine("Bo'sh joy bo'lishi mumkin emas!");
            }

        }
        else
        {
            Console.WriteLine("Sizda ma'lumot mavjud!");
        }
    }
    public void UpdateMal() 
    {
        if(File.Exists(malPath))
        {
            Console.Write("YAngi ma'lumotni kiriting: ");
            string text=Console.ReadLine();
            if (text != null)
            {
                using (StreamWriter writer = new StreamWriter(malPath))
                { writer.WriteLine(text); }
                Console.WriteLine("Ma'lumot yangilandi");
            }
            else
            {
                Console.WriteLine("Bo'sh joy kirityapsiz!");
            }

        }
        else
        {
            Console.WriteLine("Sizda hali ma'lumot mavjud emas!");
        }
    }
    public void DeleteMal() 
    {
        if( File.Exists(malPath))
        {
            File.Delete(malPath);
            Console.WriteLine("Ma'lumot o'chirildi!");
        }
        else
        {
            Console.WriteLine("Sizda ma'lumot mavjud emas!");
        }
    }
    public void ListMal() 
    {
        if(File.Exists(malPath))
        {
            using(StreamReader sr = new StreamReader(malPath))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        else
        {
            Console.WriteLine("Restoran haqida hali ma'lumot mavjud emas!");
        }
    }



}
