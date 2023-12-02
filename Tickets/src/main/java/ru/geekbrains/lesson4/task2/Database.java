package ru.geekbrains.lesson4.task2;

import java.util.ArrayList;
import java.util.Collection;

public class Database {


    public Database(){


        Customer customer1 = new Customer();
        Ticket ticket1 = new Ticket();
        Ticket ticket2 = new Ticket();
        Ticket ticket3 = new Ticket();
        customer1.getTickets().add(ticket1);
        customer1.getTickets().add(ticket2);
        customer1.getTickets().add(ticket3);
        tickets.add(ticket1);
        tickets.add(ticket2);
        tickets.add(ticket3);
        customers.add(customer1);


    }

    private static int counter = 100;

    private Collection<Ticket> tickets = new ArrayList<>();
    private Collection<Customer> customers = new ArrayList<>();

    public Collection<Ticket> getTickets() {
        return tickets;
    }

    public Collection<Customer> getCustomers() {
        return customers;
    }

    /**
     * Получить актуальную стоимость билета
     * @return
     */
    public double getTicketAmount(){
        return 45;
    }

    /**
     * Получить идентификатор заявки на покупку билета
     * @return
     */
    public int createTicketOrder(int clientId){
        return ++counter;
    }
}
