public class Controller
{
    Model controllerModel;
    View controllerView;
    public Controller(Model model, View view)
    {
        controllerModel = model;
        controllerView = view;
    }

    public void AddName()
    {
        Console.WriteLine("Write a new name:");
        string? newName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(newName))
        {
            Console.WriteLine("Naame cannot be empty!\n");
        }
        else
        {
            controllerModel.Name = newName;
        }
    }
    public void deadLift()
    {
        Console.WriteLine("Add your deadlift");
        if (int.TryParse(Console.ReadLine(), out int deadLift))
        {
            controllerModel.Strength = deadLift;
        }
    }

    public void DisplayModel()
    {
        controllerView.Display(controllerModel);
    }

}