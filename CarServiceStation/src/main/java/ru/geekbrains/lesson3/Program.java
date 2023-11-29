package ru.geekbrains.lesson3;

import java.awt.*;

public class Program {


    public static void main(String[] args) {
        SportCar sportCar = SportCar.create("A", "B", Color.BLACK, 3);
        RefuelingStation refuelingStation = new RefuelingStation();
        sportCar.setRefuelingStation(refuelingStation);
        sportCar.fuel();

    }

    public static double calculateMaintenance(Car car){
        if (car.getWheelsCount() == 6){
            return 1500 * 6;
        }
        else {
            return 1000 * 4;
        }
    }

}
