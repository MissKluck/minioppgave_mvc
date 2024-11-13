public class View
{
    //Displays the current state of the provided Model object to the user(the Model object is provided through writing (Model model)).
    public void Display(Model model)
    {
        Console.WriteLine(model.ToString());
    }

    //Allows displaying any custom message to the user, independently of Display(Model model)
    public void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}