package ru.geekbrains.lesson1.homework;

import ru.geekbrains.lesson1.homework.InMemoryModel.ModelStore;
import ru.geekbrains.lesson1.homework.InMemoryModel.Observer1;
import ru.geekbrains.lesson1.homework.InMemoryModel.Observer2;
import ru.geekbrains.lesson1.homework.ModelElements.PoligonalModel;

public class Program {

    public static void main(String[] args) {

        Observer1 observer1 = new Observer1();
        Observer2 observer2 = new Observer2();

        ModelStore modelStore = new ModelStore();
        modelStore.registerModelChanger(observer1);
        modelStore.registerModelChanger(observer2);


        modelStore.addModel(new PoligonalModel());






    }
}
