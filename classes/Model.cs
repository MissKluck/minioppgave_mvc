public class Model
{
    public string? Name { get; set; }
    public int Strength { get; set; }

    public Model(string name, int strength)
    {
        Name = name;
        Strength = strength;
    }

    public override string ToString()
    {
        return $"Name: {Name} Deadlift: {Strength}kg.";
    }
}