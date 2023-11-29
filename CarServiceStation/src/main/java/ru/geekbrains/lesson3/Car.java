package ru.geekbrains.lesson3;

import java.awt.*;

public abstract class Car {

    //region Конструкторы

    public Car(String make, String model, Color color) {
        this.make = make;
        this.model = model;
        this.color = color;
    }

    //endregion

    //region Методы

    public void setRefuelingStation(Refueling refuelingStation) {
        this.refueling = refuelingStation;
    }

    // Метод для обслуживания автомобиля
    public void service(CarService carService) {
        carService.service(this);
    }

    // Метод для заправки автомобиля
    public void refuel(Refuelable refuelable) {
        refuelable.refuel(fuelType);
    }

    /**
     * Заправить автомобиль
     */
    public void fuel() {
        if (refueling != null) {
            refueling.fuel(fuelType);
        }
    }

    // Движение
    public abstract void movement();

    // Обслуживание
    public abstract void maintenance();

    // Переключение передач
    public abstract boolean gearShifting();

    // Включение фар
    public abstract boolean switchHeadlights();

    // Включение дворников
    public abstract boolean switchWipers();

    // Состояние противотуманных фар
    private boolean fogLights = false;

    public boolean switchFogLights() {
        fogLights = !fogLights;
        return fogLights;
    }

    //endregion

    //region Поля

    private Refueling refueling;

    // Марка автомобиля
    private String make;

    // Модель
    private String model;

    // Цвет
    private Color color;

    // Тип
    protected CarType type;

    // Число колес
    protected int wheelsCount = 4;

    // Тип топлива
    protected FuelType fuelType = FuelType.Diesel;

    // Тип коробки передач
    private GearboxType gearboxType;

    // Объем двигателя
    private double engineCapacity;

    //endregion

    //region Интерфейсы

    public interface Refueling {
        void fuel(FuelType fuelType);
    }

    public interface CarService {
        void service(Car car);
    }

    public interface Refuelable {
        void refuel(FuelType fuelType);

        void wipeWindshield();

        void wipeHeadlights();

        void wipeMirrors();
    }

    //endregion
}