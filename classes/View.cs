public class View
{
    Controller controller = new Controller();


    public string nameMethod()
    {
        return controller.AddName();
    }

    public string strenghtMethod()
    {
        return controller.strenght();
    }
}