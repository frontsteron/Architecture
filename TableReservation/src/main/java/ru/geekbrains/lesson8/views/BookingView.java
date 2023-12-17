package ru.geekbrains.lesson8.views;

import ru.geekbrains.lesson8.models.Table;
import ru.geekbrains.lesson8.presenters.View;
import ru.geekbrains.lesson8.presenters.ViewObserver;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;
import java.util.List;

public class BookingView implements View {
    private ViewObserver observer;

    @Override
    public void registerObserver(ViewObserver observer) {
        this.observer = observer;
    }

    @Override
    public void showTables(Collection<Table> tables) {
        for (Table table: tables) {
            System.out.println(table);
        }
    }

    @Override
    public void reservationTable(Date orderDate, int tableNumber, String nameClients) {
        if (observer != null) {
            observer.onReservetionTable(orderDate, tableNumber, nameClients);
        }
    }

    @Override
    public void showReservationTableResult(int reservationNo) {
        if (reservationNo > 0) {
            System.out.printf("Столик успешно забронирован. Номер вашей брони: #%d\n", reservationNo);
        } else {
            System.out.println("Не удалось забронировать столик. Повторите попытку позже.");
        }
    }

    @Override
    public void changeReservationTable(int oldReservation, Date reservationDate, int tableNumber, String nameClients) {
        if (observer != null) {
            observer.onUpdateReservetionTable(oldReservation, reservationDate, tableNumber, nameClients);
        }
    }

    @Override
    public void showСhangeReservationTable(int newReservationNo, int newNumberTable) {
        if (newReservationNo > 0) {
            System.out.printf(
                    "Изменение брони прошло успешно. По номеру брони №%d изменен номер столика. Новый номер столика №%d\n",
                    newReservationNo, newNumberTable);
        } else {
            System.out.println("Не удалось забронировать столик. Повторите попытку позже.");
        }
    }
}