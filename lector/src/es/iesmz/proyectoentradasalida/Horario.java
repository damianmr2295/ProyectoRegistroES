package es.iesmz.proyectoentradasalida;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
public class Horario {

    @XmlAttribute
    private String curso;
    @XmlAttribute
    private String diaSemana;
    @XmlAttribute
    private String horaIni;
    @XmlAttribute
    private String horaFin;
    @XmlAttribute
    private String aula;
    @XmlAttribute
    private String user;


    public Horario() {
    }

    public Horario(String curso, String diaSemana, String horaIni, String horaFin, String aula, String user) {
        this.curso = curso;
        this.diaSemana = diaSemana;
        this.horaIni = horaIni;
        this.horaFin= horaFin;
        this.aula = aula;
        this.user = user;
    }

    public String getCurso() {
        return curso;
    }
    @XmlElement
    public void setCurso(String curso) {
        this.curso = curso;
    }

    public String getDiaSemana() {
        return diaSemana;
    }
    @XmlElement
    public void setDiaSemana(String diaSemana) {
        this.diaSemana = diaSemana;
    }

    public String getHoraIni() {
        return horaIni;
    }
    @XmlElement
    public void setHoraIni(String horaIni) {
        this.horaIni = horaIni;
    }

    public String getHoraFin() {
        return horaFin;
    }
    @XmlElement
    public void setHoraFin(String horaFin) {
        this.horaFin = horaFin;
    }

    public String getAula() {
        return aula;
    }
    @XmlElement
    public void setAula(String aula) {
        this.aula = aula;
    }

    public String getUser() {
        return user;
    }
    @XmlElement
    public void setUser(String user) {
        this.user = user;
    }
}
