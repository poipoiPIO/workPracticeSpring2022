public class Boat : Entity {
    public string StartingPoint  { get; set; }
    public string ArrivalPoint   { get; set; }
    public int    PassengerCount { get; set; }
    
    public Boat() =>
        (StartingPoint, ArrivalPoint, PassengerCount) =
            ("Undefined", "Undefined", 0);

    public Boat
        (int id, string name, string start, string end, int passengersCount) 
        : base(id, name)=> (StartingPoint, ArrivalPoint, PassengerCount) =
            (start, end, passengersCount);
}
