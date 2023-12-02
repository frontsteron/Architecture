package ru.geekbrains.lesson4.task2;

import java.util.Collection;
import java.util.Date;

/**
 * Мобильное приложение
 */
public class MobileApp {

    private final Customer customer;
    private final TicketProvider ticketProvider;

    public MobileApp(TicketProvider ticketProvider, CustomerProvider customerProvider){
        this.ticketProvider = ticketProvider;

        customer = customerProvider.getCustomer("login", "password");
    }

    public Collection<Ticket> getTickets(){
        return customer.getTickets();
    }

    public void searchTicket(Date date){
        customer.setTickets(ticketProvider.searchTicket(customer.getId(), new Date()));
    }

    public boolean buyTicket(String cardNo){
        return ticketProvider.buyTicket(customer.getId(), cardNo);
    }

}
