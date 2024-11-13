namespace minioppgave_mvc;

class Program
{
    static void Main(string[] args)
    {
        //Create new instances of the Model, View and Controller classes
        Model model = new Model("Wendy Chan", 168);
        View view = new View();
        Controller controller = new Controller(model, view);

        //Test displaying the initial Model data
        controller.DisplayModel();

        //Test the AddName and deadLift methods
        controller.AddName();

        controller.deadLift();

        //Display the updated Model to check if the user input was saved
        controller.DisplayModel();

        //Keep the program running
        Console.ReadLine();


    }
}
