package ru.geekbrains.lesson8.presenters;

import ru.geekbrains.lesson8.models.Table;

import java.util.Collection;
import java.util.Date;

public interface View {

    /**
     * Отображение списка столиков в приложении
     * 
     * @param tables список столиков
     */
    void showTables(Collection<Table> tables);

    /**
     * Отобразить результат бронирования столика
     * 
     * @param reservationNumber номер брони
     */
    void showReservationTableResult(int reservationNo);

    /**
     * Отобразить результат изменения бронирования столика
     * 
     * @param reservationNumber номер брони
     */
    void showСhangeReservationTable(int reservationNumber, int newNumberTable);

    /**
     * Установить наблюдателя за представлением
     * 
     * @param observer наблюдатель
     */
    void registerObserver(ViewObserver observer);
    /**
     * Действие клиента (пользователь нажал на кнопку бронирования),
     * бронирование столика
     * 
     * @param orderDate   дата бронирования
     * @param tableNumber номер столика
     * @param nameClients Имя клиента
     */
    void reservationTable(Date orderDate, int tableNumber, String nameClients);

    /**
     * Изменение брони столика (пользователь нажал на кнопку изменения резерва)
     * 
     * @param oldReservation  идентификатор бронирования (старый)
     * @param reservationDate дата бронирования
     * @param tableNumber     номер столика
     * @param nameClients     Имя
     */
    void changeReservationTable(int oldReservation, Date reservationDate, int tableNumber, String nameClients);

}
