package com.iesmz.proyectofinal.dmr.exception;

public class UserNotFoundException extends RuntimeException{

    public UserNotFoundException(long id) {
        super("Usuario no encontrada: " + id);
    }
    public UserNotFoundException(String dni) {
        super("Usuario no encontrada: " + dni);
    }
}
