using System.Collections.Generic;
public class Card{
    private List<Detatchment> _detatchments = new List<Detatchment>();
    private int morale;
    private int breakPoint;
    private int cost;
    private int points;

    public bool checkBroken(){
        return false;
    }

    public Card(List<Detatchment> _detatchments, int morale, int breakPoint, int points){
        this._detatchments=_detatchments;
        this.morale=morale;
        this.breakPoint=breakPoint;
        this.points=points;
    }
}