package ru.geekbrains.lesson3.lsp;

import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

public class Program {

    public static void main(String[] args) {
        // Тип S будет подтипом Т тогда и только тогда,
        // когда каждому объекту oS типа S соответствует некий объект oT типа T таким образом,
        // что для всех программ P,
        // реализованных в терминах T, поведение P не будет меняться, если oT заменить на oS.

        Bird bird1 = new Bird(); // oT
        Bird bird2 = new Bird(); // oT
        Bird bird3 = new Bird(); // oT
        Duck duck1 = new Duck(); // oS
        Duck duck2 = new Duck(); // oS
        Penguin penguin = new Penguin();


        List<Bird> birds = new ArrayList<>();
        birds.add(bird1);
        birds.add(bird2);
        birds.add(bird3);
        birds.add(duck1);
        birds.add(duck2);
        birds.add(penguin);

        processFly(birds);
    }

    /**
     * P
     * @param birds
     */
    public static void processFly(Collection<Bird> birds){
        for (Bird bird: birds) {
            if (bird.isCanFly())
                bird.fly();
        }
    }


}
