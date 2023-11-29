package ru.geekbrains.lesson3.lsp;

public class Penguin extends Bird{

    public Penguin(){
        flySpeed = 0;
        canFly = false;
    }

    @Override
    public void fly() {
        //System.out.println("Пингвин не умеет летать!");
        throw new RuntimeException("Пингвин не умеет летать!");
    }

}
