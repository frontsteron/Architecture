package ru.geekbrains.lesson4.task2;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;

public class TicketProvider {

    private final Database database;
    private final PaymentProvider paymentProvider;

    public TicketProvider(
            Database database,
            PaymentProvider paymentProvider
    ) {
        this.database = database;
        this.paymentProvider = paymentProvider;
    }

    public Collection<Ticket> searchTicket(int clientId, Date date) {
        Collection<Ticket> tickets = new ArrayList<>();
        for (Ticket ticket : database.getTickets()) {
            if (ticketMatches(ticket, clientId, date)) {
                tickets.add(ticket);
            }
        }
        return tickets;
    }

    private boolean ticketMatches(Ticket ticket, int clientId, Date date) {
        return ticket.getCustomerId() == clientId && ticket.getDate().equals(date);
    }

    public boolean buyTicket(int clientId, String cardNo) {
        int orderId = database.createTicketOrder(clientId);
        double amount = database.getTicketAmount();
        return paymentProvider.buyTicket(orderId, cardNo, amount);
    }

    public boolean checkTicket(String qrcode) {
        for (Ticket ticket : database.getTickets()) {
            if (ticketMatchesQrCode(ticket, qrcode)) {
                disableTicket(ticket);
                // Save database ...
                return true;
            }
        }
        return false;
    }

    private boolean ticketMatchesQrCode(Ticket ticket, String qrcode) {
        return ticket.getQrcode().equals(qrcode);
    }

    private void disableTicket(Ticket ticket) {
        ticket.setEnable(false);
    }
}