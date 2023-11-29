package ru.geekbrains.lesson3.ocp;

public class Square implements Shape{

    private int side;

    public int getSide() {
        return side;
    }

    public Square(int side) {
        this.side = side;
    }

    @Override
    public double getArea() {
        return Math.pow(side, 2);
    }
}
