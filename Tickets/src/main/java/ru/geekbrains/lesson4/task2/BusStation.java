package ru.geekbrains.lesson4.task2;

/**
 * Автобусная станция (отдельный комплекс)
 */
public class BusStation {

    private final TicketProvider ticketProvider;

    public BusStation(TicketProvider ticketProvider){
        this.ticketProvider = ticketProvider;
    }

    public boolean checkTicket(String qrCode){
        return ticketProvider.checkTicket(qrCode);
    }

}
