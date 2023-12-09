package ru.geekbrains.lesson6.notes.application.interfaces;

import ru.geekbrains.lesson6.notes.domain.Note;

import java.util.Collection;

public interface NotesDatabaseContext {

    Collection<Note> getAll();
    boolean saveChanges();

}
