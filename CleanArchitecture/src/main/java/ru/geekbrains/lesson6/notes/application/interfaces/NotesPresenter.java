package ru.geekbrains.lesson6.notes.application.interfaces;

import ru.geekbrains.lesson6.notes.domain.Note;

import java.util.Collection;

public interface NotesPresenter {

    void printAll(Collection<Note> notes);

}
