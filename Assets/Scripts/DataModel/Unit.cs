using System.Collections.Generic;

public abstract class Unit{
    protected List <Placement> _placements = new List <Placement>();
    protected MovementType movementType;
    protected int movement;
    protected int sizeCategory;

    public abstract void Hit();
}

public class StandardUnit: Unit{
    private int hitPoints;

    public StandardUnit(List <Placement> _placements, MovementType movementType, int movement, int sizeCategory, int hitPoints){
        this._placements=_placements;
        this.movementType=movementType;
        this.movement=movement;
        this.sizeCategory=sizeCategory;
        this.hitPoints=hitPoints;
    }

    public override void Hit(){
        //TODO: reduce hitPoints, die at zero
    }
}

public class SuperHeavy: Unit{
    
    public override void Hit(){
        //TODO: roll on superheavy table
    }
}

public abstract class LocationTemplateUnit: Unit{
    //TODO: define HitLocation template
}

public class Praetorian: LocationTemplateUnit{
    //TODO: Praetorian Constructor
    public override void Hit(){
        //TODO: roll on HitLocation template and resolve
    }
}

public class Titan: LocationTemplateUnit{
    //TODO: Titan Constructor
    public override void Hit(){
        //TODO: roll on HitLocation template and resolve
    }
}