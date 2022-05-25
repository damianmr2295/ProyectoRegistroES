package es.iesmz.proyectoentradasalida;


import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
public class Departamento {
    @XmlAttribute
    private String nombre;

    public Departamento() {
    }

    public Departamento(String nombre) {
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
