package ru.geekbrains.lesson8.presenters;
package ru.geekbrains.lesson8.Table;

import ru.geekbrains.lesson8.models.Table;
import java.util.Collection;
import java.util.Date;

public interface Model {

    /**
     * Зпарос на список столиков
     * 
     * @return список столиков
     */
    Collection<Table> loadTables();

    /**
     * Резервирование столиков
     * 
     * @param reservationDate дата резервирования
     * @param tableNumber     номер столика зарезервированного
     * @param nameClients     имя клиента который зарезервировал столик
     * @return номер резервирования
     */
    int reservationTable(Date reservationDate, int tableNo, String name);

    /**
     * Изменение брони столика (пользователь нажал на кнопку изменения резерва)
     * 
     * @param oldReservation  предыдущее резервирование столика
     * @param reservationDate дата резервировния
     * @param tableNumber     номер столика
     * @param nameClients     имя клиента
     * @return новый номер резервировния
     */
    int changeReservationTable(int oldReservation, Date reservationDate, int tableNumber, String nameClients);
}
