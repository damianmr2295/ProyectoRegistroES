package es.iesmz.proyectoentradasalida;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;

public class Aula {

    @XmlAttribute
    private String nombre;

    public Aula() {
    }

    public Aula(String nombre) {
        this.nombre = nombre;

    }

    public String getNombre() {
        return nombre;
    }

    @XmlElement
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
}
