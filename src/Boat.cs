public class Boat : Entity {
    public string StartingPoint  { get; set; }
    public string ArrivalPoint   { get; set; }
    public int    PassengerCount { get; set; }
    
    public Boat() =>
        (StartingPoint, ArrivalPoint, PassengerCount) =
            ("Undefined", "Undefined", 0);

    public Boat
        (string name, string start, string end, int passengersCount) 
        : base(name)=> (StartingPoint, ArrivalPoint, PassengerCount) =
            (start, end, passengersCount);
}
