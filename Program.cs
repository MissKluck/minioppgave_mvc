namespace minioppgave_mvc;

class Program
{
    static void Main(string[] args)
    {
        Model model = new Model("Wendy Chan", 168);
        View view = new View();
        Controller controller = new Controller(model, view);

        controller.DisplayModel();

        controller.AddName();

        controller.deadLift();

        controller.DisplayModel();

        Console.ReadLine();


    }
}
