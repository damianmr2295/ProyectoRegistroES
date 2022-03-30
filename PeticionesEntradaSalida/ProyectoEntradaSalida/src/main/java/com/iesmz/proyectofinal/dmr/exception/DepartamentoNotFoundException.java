package com.iesmz.proyectofinal.dmr.exception;


public class DepartamentoNotFoundException extends RuntimeException{

    public DepartamentoNotFoundException(long id) {
        super("Departamento no encontrada: " + id);
    }

}
