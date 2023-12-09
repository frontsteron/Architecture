package ru.geekbrains.lesson6.notes.application;

import ru.geekbrains.lesson6.notes.application.interfaces.NoteEditor;
import ru.geekbrains.lesson6.notes.application.interfaces.NotesDatabaseContext;
import ru.geekbrains.lesson6.notes.application.interfaces.NotesPresenter;
import ru.geekbrains.lesson6.notes.domain.Note;

import java.util.Collection;
import java.util.Date;
import java.util.Optional;

public class ConcreteNoteEditor implements NoteEditor {

    private final NotesDatabaseContext dbContext;
    private final NotesPresenter notesPresenter;

    public ConcreteNoteEditor(
            NotesPresenter notesPresenter,
            NotesDatabaseContext dbContext){
        this.dbContext = dbContext;
        this.notesPresenter = notesPresenter;
    }

    public void printAll(){
        notesPresenter.printAll(getAll());
    }

    @Override
    public boolean add(Note item) {
        dbContext.getAll().add(item);
        return dbContext.saveChanges();
    }

    @Override
    public boolean edit(Note item) {
        if (item == null)
            return false;
        Optional<Note> note = getById(item.getId());
        if (note.isEmpty())
            return false;
        note.get().setTitle(item.getTitle());
        note.get().setDetails(item.getDetails());
        note.get().setEditDate(new Date());
        note.get().setUserId(item.getUserId());

        return dbContext.saveChanges();
    }

    @Override
    public boolean remove(Note item) {
        dbContext.getAll().remove(item);
        return dbContext.saveChanges();
    }

    @Override
    public Optional<Note> getById(Integer integer) {
        return dbContext.getAll().stream().filter(p -> p.getId() == integer).findFirst();
    }

    @Override
    public Collection<Note> getAll() {
        return dbContext.getAll();
    }


}
