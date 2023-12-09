package ru.geekbrains.lesson6.notes.presentation.queries.controllers;

import ru.geekbrains.lesson6.notes.application.interfaces.NoteEditor;
import ru.geekbrains.lesson6.notes.domain.Note;
import ru.geekbrains.lesson6.notes.presentation.queries.controllers.Controller;

public class NotesController extends Controller {


    private final NoteEditor notesEditor;

    public NotesController(NoteDeleter noteDeleter) {
        this.noteDeleter = noteDeleter;
    }

    public NotesController(NoteEditor notesEditor){
        this.notesEditor = notesEditor;
    }

    public void routeAddNote(Note note) {
        this.notesEditor.add(note);
    }

    public void routeRemoveNote(Note note) {
        this.notesEditor.remove(note);
    }

    public void routeGetAll(){
        notesEditor.printAll();
    }
    public void routeDelete(int noteId) {
        noteDeleter.deleteNote(noteId);
    }


}
