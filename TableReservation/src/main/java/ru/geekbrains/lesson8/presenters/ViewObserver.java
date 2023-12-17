package ru.geekbrains.lesson8.presenters;

import java.util.Date;

public interface ViewObserver {
    
    /**
     * Произошло событие, пользователь нажал на кнопку резерва столика
     * 
     * @param orderDate   дата резерва
     * @param tableNumber номер столика
     * @param nameClients имя клиента
     */
    void onReservationTable(Date orderDate, int tableNo, String name);

    /**
     * Произошло событие изменения брони столика
     * 
     * @param oldReservation  предыдущий номер брони
     * @param reservationDate новая дата брони
     * @param tableNumber     новый номер столика
     * @param nameClients     имя клиента
     */
    void onUpdateReservetionTable(int oldReservation, Date reservationDate, int tableNumber, String nameClients);
}
