package ru.geekbrains.lesson3.lsp;

/**
 * S
 */
public class Duck extends Bird {

    public Duck(){
        flySpeed = 40;
    }

    @Override
    public void fly() {
        System.out.printf("Утка летит со скоростью %d км/ч\n", flySpeed);
    }

}
