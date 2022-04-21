package com.iesmz.proyectofinal.dmr.exception;

public class AulaNotFoundException extends RuntimeException{

    public AulaNotFoundException(long id) {
        super("Aula no Encontrada: " + id);
    }


    }
