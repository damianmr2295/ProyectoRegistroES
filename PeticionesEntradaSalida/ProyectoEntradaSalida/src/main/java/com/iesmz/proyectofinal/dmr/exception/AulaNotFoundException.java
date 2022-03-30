package com.iesmz.proyectofinal.dmr.exception;

public class AulaNotFoundException extends RuntimeException{

  /*  public ComandaNotFoundException() {
        super();
    }

    public ComandaNotFoundException(String message) {
        super(message);
    }*/
    public AulaNotFoundException(long id) {
        super("Aula no Encontrada: " + id);
    }
    /*public ComandaNotFoundException(Aula aula) {}
*/
    }
