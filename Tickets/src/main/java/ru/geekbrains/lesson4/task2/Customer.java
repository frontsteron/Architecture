package ru.geekbrains.lesson4.task2;

import java.util.ArrayList;
import java.util.Collection;

public class Customer {

    private static int counter = 100;

    public Customer(){
        id = ++counter;
    }

    private int id;
    private Collection<Ticket> tickets = new ArrayList<>();

    public Collection<Ticket> getTickets() {
        return tickets;
    }

    public void setTickets(Collection<Ticket> tickets) {
        this.tickets = tickets;
    }

    public int getId() {
        return id;
    }

}
