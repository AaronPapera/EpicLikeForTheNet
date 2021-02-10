public class Placement{
    private PlacementType type;
    private int rotationOffset;
    private int xOffset;
    private Weapon weapon;

    public Placement(PlacementType type, int rotationOffset, int xOffset, Weapon weapon){
        this.type=type;
        this.rotationOffset=rotationOffset;
        this.xOffset=xOffset;
        this.weapon=weapon;
    }
}

public enum PlacementType{
    Held,
    Turret,
    Gimbal,
    Fixed
}