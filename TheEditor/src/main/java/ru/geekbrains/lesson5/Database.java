package ru.geekbrains.lesson5;

import java.util.Collection;

public interface Database {
    void load();
    void save();
    Collection<Entity> getAll();
    void addModel(Model3D model);
    void removeModel(Model3D model);
}