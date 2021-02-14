public abstract class Weapon{
    protected int toHit;
    protected int saveMod;
    protected int range;

    public abstract void Fire();
}

public class StandardWeapon: Weapon{
    private int attacks;

    public StandardWeapon(int toHit, int saveMod, int attacks, int range){
        this.toHit=toHit;
        this.saveMod=saveMod;
        this.attacks=attacks;
        this.range=range;
    }

    public override void Fire(){
        //TODO: make it do
    }
}

public class VariableAttackWeapon: Weapon{
    private int numberOfDice;
    private int dieFaces;

    public VariableAttackWeapon(int toHit, int saveMod, int range, int numberOfDice, int dieFaces){
        this.toHit=toHit;
        this.saveMod=saveMod;
        this.range=range;
        this.numberOfDice=numberOfDice;
        this.dieFaces=dieFaces;
    }

    public int rollAttackDice(){
        int total=0;
        int count=0;
        do{
            total+=UnityEngine.Random.Range(1,this.dieFaces);
            count++;
        }while(count < numberOfDice);
        return total;
    }

    public override void Fire(){
        //TODO: make it do
    }
}

public enum Template{
    Barrage,
    LargeBarrage,
    Teardrop,
    LargeTeardrop
}

public class TemplateWeapon: Weapon{
    protected Template template;

    public TemplateWeapon(int toHit, int saveMod, int range, Template template){
        this.toHit=toHit;
        this.saveMod=saveMod;
        this.range=range;
        this.template=template;
    }

    public override void Fire(){
        //TODO: make it do
    }
}

public class BarrageWeapon: Weapon{
    protected int barragePower;
    protected Template template;

    public BarrageWeapon(int toHit, int saveMod, int range, int barragePower){
        this.toHit=toHit;
        this.saveMod=saveMod;
        this.range=range;
        this.template=0;
        this.barragePower=barragePower;
    }

    public override void Fire(){
        //TODO: make it do
    }
}