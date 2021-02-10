using System.Collections.Generic;
public abstract class Unit{
    private List <Placement> _placements = new List <Placement>();
    private int movement;

    public Unit(List <Placement> _placements, int movement){
        this._placements=_placements;
        this.movement=movement;
    }
}