package ru.geekbrains.lesson3;

import java.awt.*;

public class SportCar extends Car{


    private SportCar(String make, String model, Color color, int wheelsCount) {
        super(make, model, color);
        super.wheelsCount = wheelsCount;
    }

    public static SportCar create(String make, String model, Color color){
        return create(make, model, color, 4);
    }

    public static SportCar create(String make, String model, Color color, int wheelsCount){
        if (wheelsCount < 3 || wheelsCount > 10){
            throw new RuntimeException("Недопустимое кол-во колес.");
        }
        return new SportCar(make, model, color, wheelsCount);
    }

    @Override
    public void movement() {

    }

    @Override
    public void maintenance() {

    }

    @Override
    public boolean gearShifting() {
        return false;
    }

    @Override
    public boolean switchHeadlights() {
        return false;
    }

    @Override
    public boolean switchWipers() {
        return false;
    }
}
