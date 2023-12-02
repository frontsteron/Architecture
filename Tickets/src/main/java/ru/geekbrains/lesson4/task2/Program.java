package ru.geekbrains.lesson4.task2;

import java.util.Collection;
import java.util.Date;

public class Program {

    /**
     * Разработать контракты и компоненты системы "Покупка онлайн билетов на автобус в час пик".
     * @param args
     */
    public static void main(String[] args) {

        Core core = new Core();

        MobileApp mobileApp = new MobileApp(core.getTicketProvider(), core.getCustomerProvider());

        BusStation busStation = new BusStation(core.getTicketProvider());


        mobileApp.buyTicket("1000000000001");
        mobileApp.searchTicket(new Date());
        Collection<Ticket> tickets = mobileApp.getTickets();

        busStation.checkTicket("AAA");


    }

}
