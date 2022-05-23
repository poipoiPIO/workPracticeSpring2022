using System;
using System.Collections.Generic;

public class TransportDBase {
    public ICollection<Boat> Base { get; set; }
    
    public TransportDBase() =>
        Base = new List<Boat>();

    public Object GetInfo() => new {
            RecordsCount = Base.Count 
    };
}
