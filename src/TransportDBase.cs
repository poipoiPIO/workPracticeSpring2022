using System;
using System.Collections.Generic;

public class TransportDBase {
    public List<Boat> Base { get; set; }
    
    public TransportDBase() =>
        Base = new List<Boat>();

    public Object GetInfo() => new {
            RecordsCount = Base.Count 
    };
}
