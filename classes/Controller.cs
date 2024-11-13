public class Controller
{
    //Declares controllerModel and controllerView fields to store references to Model and View objects 
    Model controllerModel;
    View controllerView;

    //Constructor that initializes controllerModel and controllerView fields with provided Moden and View instances
    public Controller(Model model, View view)
    {
        controllerModel = model;
        controllerView = view;
    }

    //Methods
    public void AddName()
    {
        //Prompts the user for a name
        Console.WriteLine("Write a new name:");
        string? newName = Console.ReadLine();
        //If no valid name is provided, displays an error message requesting a valid name
        if (string.IsNullOrWhiteSpace(newName))
        {
            Console.WriteLine("Name cannot be empty!\n");
        }
        else
        {
            //if name is added correctly, the object's name is updated
            controllerModel.Name = newName;
        }
    }

    public void deadLift()
    {
        //Prompts the user for a deadlift weight; updates Strength if input is a valid number
        Console.WriteLine("Add your deadlift");
        if (int.TryParse(Console.ReadLine(), out int deadLift))
        {
            //If number is input correctly, the object is updated with the new number
            controllerModel.Strength = deadLift;
        }
    }

    //Uses the View to display the current state of the Model
    public void DisplayModel()
    {
        controllerView.Display(controllerModel);
    }

}