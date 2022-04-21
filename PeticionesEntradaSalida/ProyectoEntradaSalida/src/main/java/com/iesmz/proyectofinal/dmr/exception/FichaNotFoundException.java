package com.iesmz.proyectofinal.dmr.exception;

public class FichaNotFoundException extends RuntimeException{
    public FichaNotFoundException(long id){
        super("Ficha no encontrada: "+id);
    }

}
