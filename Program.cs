namespace minioppgave_mvc;

class Program
{
    static void Main(string[] args)
    {
        View view = new View();

        Console.WriteLine(view.nameMethod());
        Console.WriteLine(view.strengthMethod());
    }
}
