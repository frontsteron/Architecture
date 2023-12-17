package ru.geekbrains.lesson8.presenters;

import java.util.Date;
import ru.geekbrains.lesson8.models.Table;
import java.util.Collection;

public class BookingPresenter implements ViewObserver {

    private final Model model;
    private final View view;

    public BookingPresenter(Model model, View view){
        this.model = model;
        this.view = view;
        this.view.registerObserver(this);
    }

    /**
     * Получение списка всех столиков
     * 
     * @return список всех столиков
     */
    public Collection<Table> loadTables() {
        return model.loadTables();
    }
    
    public void updateUIShowTables() {
        view.showTables(loadTables());
    }

    public void updateUIReservationTableResult(int reservationNo) {
        view.showReservationTableResult(reservationNo);
    }

    public void updateUIShowshowСhangeReservationTable(int reservationNo, int numberTable) {
        view.showСhangeReservationTable(reservationNo, numberTable);
    }

    @Override
    public void onReservationTable(Date orderDate, int tableNumber, String nameClients) {
        try {
            int reservationNo = model.reservationTable(orderDate, tableNumber, nameClients);
            updateUIReservationTableResult(reservationNo);
        } catch (Exception e) {
            updateUIReservationTableResult(-1);
        }

    }

    @Override
    public void onUpdateReservetionTable(int oldReservation, Date reservationDate, int tableNumber,
            String nameClients) {
        try {
            int newReservationNo = model.changeReservationTable(oldReservation, reservationDate, tableNumber,
                    nameClients);
            updateUIShowshowСhangeReservationTable(newReservationNo, tableNumber);
        } catch (Exception e) {
            updateUIShowshowСhangeReservationTable(-1, -1);
        }
    }
}
