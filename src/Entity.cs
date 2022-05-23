public class Entity {
    int    Id   { get; set; }
    string Name { get; set; }

    public Entity() =>
        (Id, Name) = (0, "Undefined");

    public Entity(int id, string name) =>
        (Id, Name) = (id, name);
}
