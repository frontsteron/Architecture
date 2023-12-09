package ru.geekbrains.lesson6.notes.infrastructure.persistance;

public abstract class DbContext {

    protected Database database;

    public DbContext(Database database){
        this.database = database;
    }

    protected abstract void onModelCreating(ModelBuilder builder);

    public boolean saveChanges(){
        //TODO: Сохранение изменений в базе данных
        return true;
    }

}

class ModelBuilder{

    public ModelBuilder applyConfiguration(ModelConfiguration configuration){
        //TODO: добавление конфигурации маппинга объекта некоторого типа к структуре таблицы базы данных ...
        return this;
    }

}
