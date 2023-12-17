package ru.geekbrains.lesson8.models;
import ru.geekbrains.lesson8.presenters.Model;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;

public class TableModel implements Model {
    private Collection<Table> tables;

    @Override
    public Collection<Table> loadTables() {
        if (tables == null) {
            tables = new ArrayList<>();

            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
        }
        return tables;
    }

    @Override
    public int reservationTable(Date reservationDate, int tableNumber, String nameClients) {
        for (Table table : tables) {
            if (table.getNumber() == tableNumber) {
                Reservation reservation = new Reservation(table, reservationDate, nameClients);
                table.getReservations().add(reservation);
                return reservation.getId();
            }
        }
        throw new RuntimeException("Ошибка бронирования столика. Повторите попытку позже.");
    }

    public int changeReservationTable(int oldReservation, Date reservationDate, int tableNumber, String nameClients) {
        Reservation newReservation = null;
        for (Table table : tables) {
            for (Reservation reservation : table.getReservations()) {
                if (reservation.getId() == oldReservation) {
                    newReservation = reservation;
                }
            }
            table.getReservations().removeIf(id -> id.getId() == oldReservation);
            if (table.getNumber() == tableNumber) {
                table.getReservations().add(newReservation);
                return newReservation.getId();
            }
        }
        throw new RuntimeException("Ошибка бронирования столика. Повторите попытку позже.");
    }

}
