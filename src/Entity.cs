public class Entity {
    public string Name { get; set; }

    public Entity() =>
         Name = "Undefined";

    public Entity(string name) =>
        Name = name;
}
