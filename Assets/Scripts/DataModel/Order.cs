public abstract class Order {
    private int moveMultiplyer;
    private FiringPhase firingPhase;

    public abstract void move();
    public abstract void shoot();
}

public enum FiringPhase{
    First,
    Second
}