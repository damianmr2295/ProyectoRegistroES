package es.iesmz.proyectoentradasalida;


import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
public class Profesor {
    @XmlAttribute
    private String nombre;
    @XmlAttribute
    private String apellidos;
    @XmlAttribute
    private String departamento;
    @XmlAttribute
    private String dni;
    private String password;

    public Profesor() {
    }

    public Profesor(String nombre, String apellidos, String departamento, String dni, String password) {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.departamento = departamento;
        this.dni= dni;
        this.password = password;
    }

    public String getNombre() {
        return nombre;
    }

    @XmlElement
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    @XmlElement
    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public String getDepartamento() {
        return departamento;
    }
    @XmlElement
    public void setDepartamento(String departamento) {
        this.departamento = departamento;
    }
    public String getDni() {
        return dni;
    }
    @XmlElement
    public void setDni(String dni) {
        this.dni = dni;
    }

    public String getPassword() {
        return password;
    }
    public void setPassword(String password) {
        this.password = password;
    }
}
