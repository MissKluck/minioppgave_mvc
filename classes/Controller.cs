public class Controller
{
    Model model = new Model();

    public string AddName()
    {
        Console.WriteLine("Write a new name:");
        string? newName = Console.ReadLine();
        return newName;
    }

    public string strenght()
    {
        Console.WriteLine("Add your deadlift");
        string? deadlift = Console.ReadLine();
        //double num1 = Convert.ToDouble(deadlift);
        return deadlift;
    }

}