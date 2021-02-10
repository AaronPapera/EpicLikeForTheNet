using System.Collections.Generic;
public class Detatchment{
    private List<Unit> _units = new List<Unit>();
    private Order order;

    public void setOrders(Order order){
        this.order=order;
    }

    public void checkInstinct(){

    }

    public Detatchment (List<Unit> _units, Order order){
        this._units=_units;
        this.order=order;
    }
}