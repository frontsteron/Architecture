package ru.geekbrains.lesson3.srp;

public class SquareDrawer {

    private final Square square;
    private int scale;

    public SquareDrawer(Square square, int scale) {
        this.square = square;
        this.scale = scale;
    }

    public int getScale() {
        return scale;
    }

    public void setScale(int scale) {
        this.scale = scale;
    }

    public void draw() {
        for (int i = 0; i < square.getSide() * scale *2; i++) {
            System.out.print("*");
        }
        System.out.println();
        for (int i = 0; i < square.getSide() * scale - 2; i++) {
            System.out.print("*");
            for (int j = 1; j < square.getSide() * scale * 2 - 1; j++) {
                System.out.print(" ");
            }
            System.out.println("*");
        }
        for (int i = 0; i < square.getSide() * scale * 2; i++) {
            System.out.print("*");
        }
    }

}
