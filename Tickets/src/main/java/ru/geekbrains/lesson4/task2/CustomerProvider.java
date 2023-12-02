package ru.geekbrains.lesson4.task2;

public class CustomerProvider {

    private Database database;

    public CustomerProvider(Database database) {
        this.database = database;
    }

    public Customer getCustomer(String login, String password){
        //TODO: Процесс аутентификации
        return new Customer();
    }


}
