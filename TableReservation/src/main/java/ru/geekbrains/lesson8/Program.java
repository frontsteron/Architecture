package ru.geekbrains.lesson8;

import ru.geekbrains.lesson8.models.TableService;
import ru.geekbrains.lesson8.presenters.BookingPresenter;
import ru.geekbrains.lesson8.presenters.Model;
import ru.geekbrains.lesson8.views.BookingView;
import ru.geekbrains.lesson8.models.TableModel;
import ru.geekbrains.lesson8.presenters.View;

import java.util.Date;

public class Program {

    /**
     * TODO: Домашнее задание - метод changeReservationTable заработал!
     * @param args
     */
    public static void main(String[] args) {

        Model tableService = new TableService();
        BookingView bookingView = new BookingView();
        BookingPresenter bookingPresenter = new BookingPresenter(tableService, bookingView);
        bookingPresenter.updateUILoadTables();
        bookingView.reservationTable(new Date(), 3, "Станислав");

        bookingView.changeReservationTable(1001, new Date(), 1, "Станислав");

    }

}