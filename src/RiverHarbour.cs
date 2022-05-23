using System.Collections.Generic;
using System;

public class RiverHarbour {
    private TransportDBase _DBase;
    private List<Boat> _BoatTable;

    public RiverHarbour() {
        _DBase = new TransportDBase();
        _BoatTable = _DBase.Base;
    }

    public Object GetBaseInfo() =>
        _DBase.GetInfo();

    public Object GetAllBoats() =>
        _BoatTable.Count >= 1 ? _BoatTable : null;  

    public Object FindBoatById(int id) {
        Boat boat;
        try {
            boat = _BoatTable[id];
        } catch(Exception e) {
            Console.WriteLine(e);
            return null;
        }
        return boat;
    }

    public Object RegisterBoat(Boat boat) {
        try {
            _BoatTable.Add(boat);
        } catch (Exception e) {
            Console.WriteLine(e);
            return null;
        }
        return _BoatTable[_BoatTable.Count-1];
    }

    public Object UpdateBoatInfo(int id, Boat boat) {
        try {
            _BoatTable[id] = boat;
        } catch (Exception e) {
            Console.WriteLine(e);
            return new {Code = 404, Status = "Not Found"};
        }
        return _BoatTable[id];
    }

    public Object DeleteBoatInfo(int id) {
        try {
            _BoatTable.RemoveAt(id);
        } catch (Exception e) {
            Console.WriteLine(e);
            return null;
        }
        return new {Code = 200, Status = "Ok. Removed"};
    }
}
