package com.iesmz.proyectofinal.dmr.exception;

public class HorarioNotFoundException extends RuntimeException {
    public HorarioNotFoundException(long id) {
        super("Horario no encontrada: " + id);
    }

}
