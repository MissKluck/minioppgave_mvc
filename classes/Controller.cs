public class Controller
{
    Model model = new Model();

    public string AddName()
    {
        Console.WriteLine("Write a new name:");
        string? newName = Console.ReadLine();
        return newName;
    }

    public string strength()
    {
        Console.WriteLine("Add your deadlift");
        string? deadlift = Console.ReadLine();
        return deadlift;
    }

}