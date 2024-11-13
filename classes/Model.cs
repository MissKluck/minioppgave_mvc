public class Model
{
    //created two properties, one for Name and one for Strength
    public string? Name { get; set; }
    public int Strength { get; set; }

    //created a constructor to initialize the Name and Strength properties, allowing them to be set when a Model instance is created
    public Model(string name, int strength)
    {
        Name = name;
        Strength = strength;
    }

    //overridden ToString() to provide a formatted message displaying the name and strength, which the view class can use to display to the user
    public override string ToString()
    {
        return $"Name: {Name} Deadlift: {Strength}kg.";
    }
}