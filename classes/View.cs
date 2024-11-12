public class View
{

    public void Display(Model model)
    {
        Console.WriteLine(model.ToString());
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }

    //public string nameMethod()
    //{
    //    return controller.AddName();
    //}
    //
    //public string strengthMethod()
    //{
    //    return controller.strength();
    //}
}