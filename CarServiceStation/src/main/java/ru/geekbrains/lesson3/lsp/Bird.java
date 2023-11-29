package ru.geekbrains.lesson3.lsp;

/**
 * T
 */
public class Bird {

    protected int flySpeed = 30;
    protected boolean canFly = true;

    public boolean isCanFly() {
        return canFly;
    }

    public void fly() {
        System.out.printf("Птица летит со скоростью %d км/ч\n", flySpeed);
    }
}
