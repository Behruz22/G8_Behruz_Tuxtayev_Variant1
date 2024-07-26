using ExaminProject_2_modul;

class Program
{
    public static void Main(string[] args)
    {
		try
		{
            Worker worker = new Worker();
        }
		catch (Exception)
		{

            Console.WriteLine("Tizimda muammo!");
        }
        finally
        {
            Console.WriteLine("Dastur tugadi!");
        }
        
    }
}